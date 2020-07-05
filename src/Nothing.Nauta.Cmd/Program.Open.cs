namespace Nothing.Nauta.Cmd
{
    using System;
    using System.Collections.Generic;
    using System.CommandLine;
    using System.CommandLine.Invocation;
    using System.IO;
    using System.Net.Http;
    using System.Text.Json;

    using Polly;

    using Serilog;

    internal static partial class Program
    {
        private static Command CreateOpenCommand()
        {
            var command = new Command("open", "Open Nauta session")
                              {
                                  CommonArguments.CredentialsFile,
                                  CommonArguments.SessionFile
                              };

            command.Handler = CommandHandler.Create<FileInfo, FileInfo>(
                async (credentialsFile, sessionFile) =>
                    {
                        Log.Information("Opening Nauta session...");

                        Dictionary<string, string> sessionData = null;
                        if (File.Exists(credentialsFile.FullName))
                        {
                            Dictionary<string, string> credentials = null;
                            try
                            {
                                var content = await File.ReadAllTextAsync(credentialsFile.FullName);
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
                                    Log.Error(e, "Error opening Nauta session.");
                                }

                                if (sessionData != null)
                                {
                                    await File.WriteAllTextAsync(
                                        sessionFile.FullName,
                                        JsonSerializer.Serialize(
                                            sessionData,
                                            new JsonSerializerOptions { WriteIndented = true }));

                                    Log.Information("Nauta session open for user '{Username}'.", username);

                                    var policy = Policy.Handle<HttpRequestException>().Or<FormatException>()
                                        .WaitAndRetryForeverAsync(
                                            retryAttempt => TimeSpan.FromSeconds(5),
                                            (exception, retry, timeSpan) =>
                                                {
                                                    Log.Error(exception, "Error query time in the Nauta session.");
                                                });

                                    var remainingTime =
                                        await policy.ExecuteAsync(() => sessionHandler.RemainingTimeAsync(sessionData));
                                    Log.Information(
                                        "Remaining Time: '{RemainingTime}'.",
                                        $"{(int)remainingTime.TotalHours}hrs {remainingTime:mm}mn {remainingTime:ss}sec");
                                }
                            }
                        }
                        else
                        {
                            Log.Information("Save credentials first with credential command.");
                        }
                    });

            return command;
        }
    }
}