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
            var command = new Command("credentials", "Save Nauta credentials");

            command.AddOption(
                new Option(new[] { "--username", "-u" })
                    {
                        Argument = new Argument<string>("username"), 
                        Required = true
                    });

            command.AddOption(
                new Option(new[] { "--password", "-p" })
                    {
                        Argument = new Argument<string>("password"), 
                        Required = true
                    });

            command.AddOption(
                new Option(new[] { "--alias", "-a" })
                    {
                        Argument = new Argument<string>("alias"), 
                        Required = false, 
                    });

            command.Handler = CommandHandler.Create<string, string, string>(
                async (username, password, alias) =>
                    {
                        Log.Information("Saving Nauta session credentials...");

                        var credentials = new Dictionary<string, string>
                                              {
                                                  ["username"] = username, ["password"] = password
                                              };

                        try
                        {
                            var credentialsFile = FilesHelper.GetCredentialFile(alias);
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