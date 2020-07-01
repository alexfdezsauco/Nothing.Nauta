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
        private static Command CreateOpenCommand()
        {
            var command = new Command("open", "Open Nauta session");

            command.Handler = CommandHandler.Create(
                async () =>
                    {
                        Log.Information("Opening Nauta session...");

                        Dictionary<string, string> sessionData = null;
                        if (File.Exists("credentials.json"))
                        {
                            var content = await File.ReadAllTextAsync("credentials.json");
                            Dictionary<string, string> credentials = null;

                            try
                            {
                                credentials = JsonSerializer.Deserialize<Dictionary<string, string>>(content);
                            }
                            catch (Exception e)
                            {
                                Log.Error(e, "Error deserializing credentials");
                            }

                            if (credentials != null && credentials.TryGetValue("username", out var username)
                                                    && credentials.TryGetValue("password", out var password))
                            {
                                var sessionHandler = new SessionHandler();
                                try
                                {
                                    sessionData = await sessionHandler.OpenAsync(username, password);
                                }
                                catch (Exception e)
                                {
                                    Log.Error(e, "Error opening Nauta session");
                                }

                                if (sessionData != null)
                                {
                                    await File.WriteAllTextAsync(
                                        "session.json",
                                        JsonSerializer.Serialize(
                                            sessionData,
                                            new JsonSerializerOptions { WriteIndented = true }));

                                    Log.Information("Nauta session opened for user '{Username}'", username);
                                }
                            }
                        }
                        else
                        {
                            Log.Error("Save credentials first with credential command.");
                        }
                    });

            return command;
        }
    }
}