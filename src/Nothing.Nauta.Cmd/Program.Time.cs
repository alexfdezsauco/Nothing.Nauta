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
            var command = new Command("time", "Display the remaining time from the opened Nauta session");

            command.Handler = CommandHandler.Create(
                async () =>
                    {
                        Log.Information("Querying remaining time from the Nauta session...");

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
                            var policy = Policy.Handle<HttpRequestException>().WaitAndRetryForeverAsync(
                                retryAttempt => TimeSpan.FromSeconds(5),
                                (exception, retry, timeSpan) =>
                                    {
                                        Log.Error(exception, "Error query time in the Nauta session.");
                                    });

                            var sessionHandler = new SessionHandler();
                            var remainingTime =
                                await policy.ExecuteAsync(() => sessionHandler.RemainingTimeAsync(sessionData));

                            Log.Information(
                                "Remaining Time: '{Time}'",
                                $"{(int)remainingTime.TotalHours}hrs {remainingTime:mm}mn {remainingTime:ss}sec");
                        }
                    });

            return command;
        }
    }
}