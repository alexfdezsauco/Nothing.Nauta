#load "config.cake"

var target = Argument("target", "Default");

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

Task("Default")
  .Does(() =>
{
  Information("Hello World!");
});

RunTarget(target);