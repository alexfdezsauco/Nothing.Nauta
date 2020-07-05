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
        private static Command CreateTimeCommand()
        {
            var command = new Command("time", "Display the remaining time from the open Nauta session")
                              {
                                  CommonArguments.SessionFile
                              };

            command.Handler = CommandHandler.Create<FileInfo>(
                async (sessionFile) =>
                    {
                        Log.Information("Querying remaining time from the Nauta session...");

                        Dictionary<string, string> sessionData = null;
                        try
                        {
                            var sessionContent = await File.ReadAllTextAsync(sessionFile.FullName);
                            sessionData = JsonSerializer.Deserialize<Dictionary<string, string>>(sessionContent);
                        }
                        catch (Exception e)
                        {
                            Log.Error(e, "Error deserializing session data.");
                        }

                        if (sessionData != null)
                        {
                            var policy = Policy.Handle<HttpRequestException>().Or<FormatException>()
                                .WaitAndRetryForeverAsync(
                                    retryAttempt => TimeSpan.FromSeconds(5),
                                    (exception, retry, timeSpan) =>
                                        {
                                            Log.Error(exception, "Error query time in the Nauta session.");
                                        });

                            DateTime startDateTime = default;
                            var isTimeAvailable = sessionData.TryGetValue(SessionDataKeys.Started, out var started)
                                                  && DateTime.TryParse(started, out startDateTime);

                            var sessionHandler = new SessionHandler();
                            var remainingTime =
                                await policy.ExecuteAsync(() => sessionHandler.RemainingTimeAsync(sessionData));

                            Log.Information(
                                "Remaining Time: '{RemainingTime}'.",
                                $"{(int)remainingTime.TotalHours}hrs {remainingTime:mm}mn {remainingTime:ss}sec");

                            if (isTimeAvailable)
                            {
                                var elapsedTime = DateTime.Now.Subtract(startDateTime);
                                Log.Information(
                                    "Elapsed Time: '{ElapsedTime}'.",
                                    $"{(int)elapsedTime.TotalHours}hrs {elapsedTime:mm}mn {elapsedTime:ss}sec");
                            }
                        }
                        else
                        {
                            Log.Information("This command requires an open session. Open a nauta session first with open command.");
                        }
                    });

            return command;
        }
    }
}