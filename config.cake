string NuGetVersionV2 = "";
string SolutionFileName = "src/Nothing.Nauta.sln";

var DockerFiles = System.Array.Empty<string>();
var OutputImages = System.Array.Empty<string>();

var ComponentProjects  = new [] 
{
    "src/Nothing.Nauta/Nothing.Nauta.csproj"
};

var ExecProjects  = new [] 
{
    "src/Nothing.Nauta.Cmd/Nothing.Nauta.Cmd.csproj"
};

var ExecProjectsOutputDirectories  = new [] 
{
    "output/release/nauta-session/{0}/{1}"
};

var RuntimeIdentifiers  = new string [] 
{
    "win-x86",
    "win-x64",
    "linux-x64",
    "linux-arm",
    "linux-arm64",
    "osx-x64"
};

var MauiProjects  = new [] 
{
    "src/Nothing.Nauta.App/Nothing.Nauta.App.csproj"
};

var MauiProjectsOutputDirectories  = new [] 
{
    "output/release/nauta-session-app/{0}"
};

var MauiFrameworkRuntimeIdentifiers  = new (string Framework, string RuntimeIdentifier) [] 
{
    (Framework:"net6.0-android", RuntimeIdentifier:string.Empty),
    (Framework:"net6.0-windows10.0.19041.0", RuntimeIdentifier:"win-x86"),
    (Framework:"net6.0-windows10.0.19041.0", RuntimeIdentifier:"win-x64"),
    // "net6.0-ios",
    // "net6.0-maccatalyst"
};

var TestProject = "src/Nothing.Nauta.Tests/Nothing.Nauta.Tests.csproj";

var SonarProjectKey = "stoneassemblies_Nothing.Nauta";
var SonarOrganization = "stoneassemblies";