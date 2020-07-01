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
                                    Log.Error(e, "Error opening Nauta session.");
                                }

                                if (sessionData != null)
                                {
                                    await File.WriteAllTextAsync(
                                        "session.json",
                                        JsonSerializer.Serialize(
                                            sessionData,
                                            new JsonSerializerOptions { WriteIndented = true }));

                                    Log.Information("Nauta session opened for user '{Username}'.", username);

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
                            Log.Error("Save credentials first with credential command.");
                        }
                    });

            return command;
        }
    }
}