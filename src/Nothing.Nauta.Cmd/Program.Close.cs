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
        private static Command CreateCloseCommand()
        {
            var command = new Command("close", "Close Nauta session");

            command.Handler = CommandHandler.Create(
                async () =>
                    {
                        Log.Information("Closing Nauta session...");

                        var sessionContent = await File.ReadAllTextAsync("session.json");
                        Dictionary<string, string> sessionData = null;
                        try
                        {
                            sessionData = JsonSerializer.Deserialize<Dictionary<string, string>>(sessionContent);
                        }
                        catch (Exception e)
                        {
                            Log.Error(e, "Error deserializing session data.");
                        }

                        if (sessionData != null)
                        {
                            // TODO: Improve this
                            var policy = Policy.Handle<HttpRequestException>().WaitAndRetryForeverAsync(
                                retryAttempt => TimeSpan.FromSeconds(5),
                                (exception, retry, timeSpan) =>
                                    {
                                        Log.Error(exception, "Error closing Nauta session.");
                                    });

                            DateTime startDateTime = default;
                            var isTimeAvailable = sessionData.TryGetValue(SessionDataKeys.Started, out var started)
                                                  && DateTime.TryParse(started, out startDateTime);

                            var sessionHandler = new SessionHandler();
                            await policy.ExecuteAsync(() => sessionHandler.CloseAsync(sessionData));
                            var endDateTime = DateTime.Now;

                            try
                            {
                                File.Delete("session.json");
                            }
                            catch (Exception e)
                            {
                                Log.Error(e, "Error deleting persisted session");
                            }

                            if (isTimeAvailable)
                            {
                                var elapsedTime = endDateTime.Subtract(startDateTime);
                                Log.Information("Nauta session closed. Duration: '{Duration}'.", $"{(int)elapsedTime.TotalHours}hrs {elapsedTime:mm}mn {elapsedTime:ss}sec");
                            }
                            else
                            {
                                Log.Information("Nauta session closed.");
                            }
                        }
                    });

            return command;
        }
    }
}