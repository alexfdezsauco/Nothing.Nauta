#load "config.cake"

var target = Argument("target", "Default");
var buildConfiguration = Argument("Configuration", "Release");

Setup (context => {
  context.Tools.RegisterFile("./tools/GitVersion.CommandLine/tools/GitVersion.exe");
});

Task ("UpdateVersion")
  .Does (() => {
    FilePath gitVersionPath = Context.Tools.Resolve ("GitVersion.exe");
    StartProcess (gitVersionPath, new ProcessSettings {
      Arguments = new ProcessArgumentBuilder ()
        .Append ("/output")
        .Append ("buildserver")
        .Append ("/nofetch")
        .Append ("/updateassemblyinfo")
    });

    IEnumerable<string> redirectedStandardOutput;
    StartProcess (gitVersionPath, new ProcessSettings {
      Arguments = new ProcessArgumentBuilder ()
        .Append ("/output")
        .Append ("json"),
        RedirectStandardOutput = true
    }, out redirectedStandardOutput);

    NuGetVersionV2 = redirectedStandardOutput.FirstOrDefault (s => s.Contains ("NuGetVersionV2")).Split (':') [1].Trim (',').Trim ('"');
  });

  Task("Restore")
  .Does(() => {

  });

Task("Build")
  .IsDependentOn("UpdateVersion")
  .IsDependentOn("Restore")
  .Does (() => 
  {
     DotNetCoreBuild(
                SolutionFileName,
                new DotNetCoreBuildSettings()
                {
                    Configuration = buildConfiguration,
                    ArgumentCustomization = args => args
                        .Append($"/p:Version={NuGetVersionV2}")
                        .Append($"/p:PackageVersion={NuGetVersionV2}")
                });
  });  

Task("Pack")
  .IsDependentOn ("Build")
  .Does (() => 
  {
      for(int i = 0; i < ComponentProjects.Length; i++)
      {
        var componentProject = ComponentProjects[i];
        var packageOutputDirectory = $"./output/nuget";
        var settings = new DotNetCorePackSettings
        {
            Configuration = buildConfiguration,
            OutputDirectory = packageOutputDirectory,
            ArgumentCustomization = args => args
                .Append($"/p:PackageVersion={NuGetVersionV2}")
                .Append($"/p:Version={NuGetVersionV2}")
        };

        DotNetCorePack(componentProject, settings);
      }
  });

Task("Default")
  .Does(() =>
{
  Information("Hello World!");
});

RunTarget(target);