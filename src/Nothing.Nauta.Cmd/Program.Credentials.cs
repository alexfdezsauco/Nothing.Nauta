namespace Nothing.Nauta.Cmd
{
    using System;
    using System.Collections.Generic;
    using System.CommandLine;
    using System.CommandLine.Invocation;
    using System.IO;
    using System.Text.Json;

    using Serilog;

    internal static partial class Program
    {
        private static Command CreateCredentialsCommand()
        {
            var command = new Command("credentials", "Save Nauta credentials")
                              {
                                  CommonArguments.CredentialsFile
                              };

            command.AddOption(
                new Option("--username", "-u") { Argument = new Argument<string>("username"), Required = true });

            command.AddOption(
                new Option("--password", "-p") { Argument = new Argument<string>("password"), Required = true });

            command.Handler = CommandHandler.Create<string, string, FileInfo>(
                async (username, password, credentialsFile) =>
                    {
                        Log.Information("Saving Nauta session credentials...");

                        var credentials = new Dictionary<string, string>
                                              {
                                                  ["username"] = username, ["password"] = password
                                              };

                        try
                        {
                            await File.WriteAllTextAsync(
                                credentialsFile.FullName,
                                JsonSerializer.Serialize(
                                    credentials,
                                    new JsonSerializerOptions { WriteIndented = true }));

                            Log.Information("Nauta session credentials for user 'Username' saved.", username);
                        }
                        catch (Exception e)
                        {
                            Log.Error(e, "Error saving credentials");
                        }
                    });
            return command;
        }
    }
}