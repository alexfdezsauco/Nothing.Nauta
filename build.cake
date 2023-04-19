#addin "Cake.Docker"
#addin "Cake.FileHelpers"

#load "config.cake"

using System.Text.RegularExpressions;

var target = Argument("target", "Pack");
var buildConfiguration = Argument("Configuration", "Release");

using System.Net;
using System.Net.Sockets;

// var adapter = NetworkInformation.NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(i => i.Name == "Wi-Fi");
// var properties = adapter.GetIPProperties();

string localIpAddress;
using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
{
    socket.Connect("8.8.8.8", 65530);
    var endPoint = socket.LocalEndPoint as IPEndPoint;
    localIpAddress = endPoint.Address.ToString();
}

var dockerRepositoryProxy = EnvironmentVariable("DOCKER_REPOSITORY_PROXY") ?? $"mcr.microsoft.com";
var dockerRepository = EnvironmentVariable("DOCKER_REPOSITORY") ?? string.Empty;
var dockerRepositoryUsername = EnvironmentVariable("DOCKER_REPOSITORY_USERNAME") ?? string.Empty;
var dockerRepositoryPassword = EnvironmentVariable("DOCKER_REPOSITORY_PASSWORD") ?? string.Empty;

var nugetRepositoryProxy = EnvironmentVariable("NUGET_REPOSITORY_PROXY") ?? $"https://api.nuget.org/v3/index.json";
var nugetRepository = EnvironmentVariable("NUGET_REPOSITORY");
var nugetApiKey = EnvironmentVariable("NUGET_API_KEY");

var DockerRepositoryPrefix = string.IsNullOrWhiteSpace(dockerRepository) ? string.Empty : dockerRepository + "/";

var sonarToken = EnvironmentVariable("SONAR_TOKEN");
var sonarUrl = EnvironmentVariable("SONAR_URL") ?? "https://sonarcloud.io/";

string GetCoverageFilePath() 
{
    if (string.IsNullOrWhiteSpace(TestProject))
    {
        return string.Empty;
    }

    var testDirectoryPath = System.IO.Path.GetDirectoryName(TestProject);
    return System.IO.Path.GetFullPath($"{testDirectoryPath}/coverage.opencover.xml");
}

string GetTestResultFilePath() 
{
    if (string.IsNullOrWhiteSpace(TestProject))
    {
        return string.Empty;
    }

    var testDirectoryPath = System.IO.Path.GetDirectoryName(TestProject);
    return System.IO.Path.GetFullPath($"{testDirectoryPath}/TestResults.trx");
}

Task("UpdateVersion")
  .Does(() => 
  {
      StartProcess("dotnet", new ProcessSettings
      {
          Arguments = new ProcessArgumentBuilder()
            .Append("gitversion")
            .Append("/output")
            .Append("buildserver")
            .Append("/nofetch")
            .Append("/updateassemblyinfo")
      });

      IEnumerable<string> redirectedStandardOutput;
      StartProcess("dotnet", new ProcessSettings
      {
          Arguments = new ProcessArgumentBuilder()
            .Append("gitversion")
            .Append("/output")
            .Append("json")
            .Append("/nofetch"),
          RedirectStandardOutput = true
      }, out redirectedStandardOutput);

      NuGetVersionV2 = redirectedStandardOutput.FirstOrDefault(s => s.Contains("NuGetVersionV2")).Split(':')[1].Trim(',', ' ', '"');
      Information($"CurrentVersion => {NuGetVersionV2}");
});

Task("Restore")
  .Does(() => 
  {
      Information("Restoring Solution Packages");
      DotNetRestore(SolutionFileName, new DotNetRestoreSettings()
      {
          Sources = new[] { nugetRepositoryProxy },
          NoCache = true
      });
});

Task("Build")
  .IsDependentOn("UpdateVersion")
  .IsDependentOn("Restore")
  .Does(() => 
  {
      DotNetBuild(
                  SolutionFileName,
                  new DotNetBuildSettings()
                  {
                      Configuration = buildConfiguration,
                      ArgumentCustomization = args => args
                          .Append($"/p:Version={NuGetVersionV2}")
                          .Append($"/p:PackageVersion={NuGetVersionV2}")
                  });
  }); 

Task("Test")
  .IsDependentOn("Build")
  .Does(() => 
  {
    if (!string.IsNullOrWhiteSpace(TestProject))
    {
      var settings = new DotNetTestSettings
        {
          NoWorkingDirectory = true,
          Configuration = buildConfiguration,
	  Filter = "TestCategory=Unit",
          ArgumentCustomization = args => args
            .Append("/p:CollectCoverage=true")
            .Append("/p:CoverletOutputFormat=opencover")
            // .Append("/p:ExcludeByAttribute=\"Obsolete%2GeneratedCodeAttribute\"")
        };

      settings.Loggers.Add($"trx;LogFileName={GetTestResultFilePath()}");
      settings.Collectors.Add("XPlat Code Coverage");

      DotNetTest(TestProject, settings);	
    }
  });

Task("Sonar-Begin")
  .IsDependentOn("UpdateVersion")
  .Does(() => 
  {
      StartProcess("dotnet", new ProcessSettings
      {
          Arguments = new ProcessArgumentBuilder()
            .Append("sonarscanner")
            .Append("begin")
            .Append($"/k:{SonarProjectKey}")
            .Append($"/o:{SonarOrganization}")
            .Append($"/v:{NuGetVersionV2}")
            .Append($"/d:sonar.cs.opencover.reportsPaths={GetCoverageFilePath()}")
            .Append($"/d:sonar.cs.vstest.reportsPaths={GetTestResultFilePath()}")
            .Append($"/d:sonar.host.url={sonarUrl}")
            .Append($"/d:sonar.login={sonarToken}")
      });
  });

Task("Sonar-End")
  .Does(() => 
  {
      StartProcess("dotnet", new ProcessSettings
      {
          Arguments = new ProcessArgumentBuilder()
            .Append("sonarscanner")
            .Append("end")
            .Append($"/d:sonar.login={sonarToken}")
      });
  });

Task("Sonar")
  .IsDependentOn("Sonar-Begin")
  .IsDependentOn("Test")
  .IsDependentOn("Sonar-End");

Task("Publish")
  .IsDependentOn("Build")
  .Does(() => 
  {
      EnsureDirectoryExists("./output/zip");

      for (var i = 0; i < ExecProjects.Length; i++)
      {
          var projectFile = ExecProjects[i];
          var outputDirectoy = ExecProjectsOutputDirectories[i];
          foreach (var runtimeIdentifier in RuntimeIdentifiers)
          {
              Information($"Publishing executable for {projectFile} for runtime {runtimeIdentifier} ...");
              DotNetPublish(projectFile, new DotNetPublishSettings()
              {
                  PublishSingleFile = true,
                  SelfContained = false,
                  Runtime = runtimeIdentifier,
                  Configuration = buildConfiguration,
                  OutputDirectory = string.Format(outputDirectoy, runtimeIdentifier, "non-self-contained")
              });              

              var nonSelfContainedFiles = GetFiles(string.Format(outputDirectoy, runtimeIdentifier, "non-self-contained") + "/**/*");
              Zip(string.Format(outputDirectoy, runtimeIdentifier, "non-self-contained"), $"output/zip/nauta-session-cli-{runtimeIdentifier}-non-self-contained-{NuGetVersionV2}.zip", nonSelfContainedFiles.Where(f => !f.FullPath.EndsWith(".pdb")));

              Information($"Publishing self-container executable for {projectFile} for runtime {runtimeIdentifier} ...");
              DotNetPublish(projectFile, new DotNetPublishSettings()
              {
                  PublishSingleFile = true,
                  SelfContained = true,
                  Runtime = runtimeIdentifier,
                  Configuration = buildConfiguration,
                  OutputDirectory = string.Format(outputDirectoy, runtimeIdentifier, "self-contained")
              });

              var selfContainedFiles = GetFiles(string.Format(outputDirectoy, runtimeIdentifier, "self-contained") + "/**/*");
              Zip(string.Format(outputDirectoy, runtimeIdentifier, "self-contained"), $"output/zip/nauta-session-cli-{runtimeIdentifier}-self-contained-{NuGetVersionV2}.zip", selfContainedFiles.Where(f => !f.FullPath.EndsWith(".pdb")));
          }
      }

      for (var i = 0; i < MauiProjects.Length; i++)
      {
          var projectFile = MauiProjects[i];
          var outputDirectoy = MauiProjectsOutputDirectories[i];
          foreach (var frameworkRuntimeIdentifier in MauiFrameworkRuntimeIdentifiers)
          {
              Information($"Publishing app for {projectFile} for target framework {frameworkRuntimeIdentifier.Framework} {frameworkRuntimeIdentifier.RuntimeIdentifier} ...");
              var settings = new DotNetPublishSettings()
              {
                  Configuration = buildConfiguration,
                  OutputDirectory = string.Format(outputDirectoy, frameworkRuntimeIdentifier.Framework) + $"/{frameworkRuntimeIdentifier.RuntimeIdentifier}".TrimEnd('/'),
                  Framework = frameworkRuntimeIdentifier.Framework
              };

              if (!string.IsNullOrWhiteSpace(frameworkRuntimeIdentifier.RuntimeIdentifier))
              {
                  settings.ArgumentCustomization = args => args.Append($"-p:RuntimeIdentifierOverride={frameworkRuntimeIdentifier.RuntimeIdentifier}");                
              }

              DotNetPublish(projectFile, settings);    

              var files = GetFiles(settings.OutputDirectory + "/**/*");
              Zip(settings.OutputDirectory, $"output/zip/nauta-session-app-{frameworkRuntimeIdentifier.Framework}-{frameworkRuntimeIdentifier.RuntimeIdentifier}-{NuGetVersionV2}.zip".Replace("--", "-"), files.Where(f => !f.FullPath.EndsWith(".aab") && !f.FullPath.EndsWith(".pdb")));
          }
      }
  });   

Task("DockerBuild")
  .IsDependentOn("UpdateVersion")
  .Does(() => 
  {
      if (DockerFiles.Length != OutputImages.Length)
      {
          Error("DockerFiles.Length != OutputImages.Length");
      }

      var tarFileName = "dotnet.csproj.tar.gz";

      using (var process = StartAndReturnProcess("tar", new ProcessSettings { Arguments = $"-cf {tarFileName} -C src {System.IO.Path.GetFileName(SolutionFileName)}" }))
      {
          process.WaitForExit();
      }

      var srcFilePath = GetDirectories("src").FirstOrDefault();
      var files = GetFiles("./src/**/*.csproj");
      foreach (var file in files)
      {
          var relativeFilePath = srcFilePath.GetRelativePath(file);
          using (var process = StartAndReturnProcess("tar", new ProcessSettings { Arguments = $"-rf {tarFileName} -C src {relativeFilePath}" }))
          {
              process.WaitForExit();
          }
      }

      var singleNodeTemplateDeployFile = $"./deployment/singlenode/deploy.ps1";
      var singleNodeDeployFile = $"./output/singlenode/deploy.ps1";
      if (FileExists(singleNodeTemplateDeployFile))
      {
          EnsureDirectoryExists($"./output/singlenode");
          CopyFile(singleNodeTemplateDeployFile, singleNodeDeployFile);
          ReplaceTextInFiles(singleNodeDeployFile, "${VERSION_NUMBER}", NuGetVersionV2);
      }

      var deployFile = $"./deployment/marathon/deploy.ps1";
      if (FileExists(deployFile))
      {
          EnsureDirectoryExists($"./output/marathon");
          CopyFile(deployFile, "./output/marathon/deploy.ps1");
      }

      for (int i = 0; i < DockerFiles.Length; i++)
      {
          var outputImage = OutputImages[i];
          var dockerFile = DockerFiles[i];

          var taskFile = $"./deployment/marathon/{outputImage}/task.json";
          if (FileExists(taskFile))
          {
              EnsureDirectoryExists($"./output/marathon/{outputImage}");
              CleanDirectory($"./output/marathon/{outputImage}");

              var outputTaskFileName = $"./output/marathon/{outputImage}/task.json";
              CopyFile(taskFile, outputTaskFileName);

              ReplaceTextInFiles(outputTaskFileName, "${VERSION_NUMBER}", NuGetVersionV2);
          }

          var settings = new DockerImageBuildSettings()
          {
              File = dockerFile,
              BuildArg = new[] {$"DOCKER_REPOSITORY_PROXY={dockerRepositoryProxy}",
                                                  $"NUGET_REPOSITORY_PROXY={nugetRepositoryProxy}",
                                                  $"PACKAGE_VERSION={NuGetVersionV2}"},
              Tag = new[] { $"{DockerRepositoryPrefix}{outputImage}:{NuGetVersionV2}", $"{DockerRepositoryPrefix}{outputImage}:latest" },
              // Network = "stoneassemblies-massauth-network"
          };
          DockerBuild(settings, "./");
      }
  });

Task("NuGetPack")
  .IsDependentOn("Build")
  .Does(() => 
  {
    var packageOutputDirectory = $"./output/nuget";
    EnsureDirectoryExists(packageOutputDirectory);
    CleanDirectory(packageOutputDirectory);
    
    for (int i = 0; i < ComponentProjects.Length; i++)
    {
        var componentProject = ComponentProjects[i];
        var settings = new DotNetPackSettings
        {
            Configuration = buildConfiguration,
            OutputDirectory = packageOutputDirectory,
            IncludeSymbols = true,
            ArgumentCustomization = args => args
                .Append($"/p:PackageVersion={NuGetVersionV2}")
                .Append($"/p:Version={NuGetVersionV2}")
        };

        DotNetPack(componentProject, settings);
    }

    EnsureDirectoryExists("./output/nuget-symbols");
    CleanDirectory("./output/nuget-symbols");

    MoveFiles($"{packageOutputDirectory}/*.symbols.nupkg", "./output/nuget-symbols");
    var symbolFiles  = GetFiles("./output/nuget-symbols/*.symbols.nupkg");
    foreach(var symbolFile in symbolFiles)
    {
        var newFileName = symbolFile.ToString().Replace(".symbols", "");
        MoveFile(symbolFile, newFileName);
    }
});

Task("NuGetPush")
   .IsDependentOn("NuGetPack")
   .Does(()=> 
{
	var nugetFiles  = GetFiles("./output/nuget/*.nupkg");
	foreach(var nugetFile in nugetFiles)
        {
		DotNetNuGetPush(nugetFile.ToString(), new DotNetNuGetPushSettings {
		     Source = nugetRepository,
		     ApiKey = nugetApiKey
		});
	}

});

Task("DockerPush")
  .IsDependentOn("DockerBuild")
  .Does(() => 
  {
      DockerLogin(dockerRepositoryUsername, dockerRepositoryPassword, dockerRepository);
      for (int i = 0; i < DockerFiles.Length; i++)
      {
           var outputImage = OutputImages[i];
           DockerPush($"{DockerRepositoryPrefix}{outputImage}:{NuGetVersionV2}");
      }
  });

RunTarget(target);