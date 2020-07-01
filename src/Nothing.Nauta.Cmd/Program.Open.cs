namespace Nothing.Nauta.Cmd
{
    using System;
    using System.Collections.Generic;
    using System.CommandLine;
    using System.CommandLine.Invocation;
    using System.IO;
    using System.Text.Json;

    using Nothing.Nauta;

    using Serilog;

    internal static partial class Program
    {
        private static Command CreateOpenCommand()
        {
            var command = new Command("open", "Open Nauta session");

            command.Handler = CommandHandler.Create(
                async () =>
                    {
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

                            if (credentials != null)
                            {
                                var sessionHandler = new SessionHandler();
                                try
                                {
                                    sessionData = await sessionHandler.OpenAsync(
                                                      credentials["username"],
                                                      credentials["password"]);
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