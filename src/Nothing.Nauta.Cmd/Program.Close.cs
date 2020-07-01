﻿namespace Nothing.Nauta.Cmd
{
    using System;
    using System.Collections.Generic;
    using System.CommandLine;
    using System.CommandLine.Invocation;
    using System.IO;
    using System.Net.Http;
    using System.Text.Json;

    using Nothing.Nauta;

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

                        var content = await File.ReadAllTextAsync("session.json");
                        Dictionary<string, string> sessionData = null;
                        try
                        {
                            sessionData = JsonSerializer.Deserialize<Dictionary<string, string>>(content);
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

                            var sessionHandler = new SessionHandler();
                            await policy.ExecuteAsync(() => sessionHandler.CloseAsync(sessionData));

                            try
                            {
                                File.Delete("session.json");
                            }
                            catch (Exception e)
                            {
                                Log.Error(e, "Error deleting persisted session");
                            }

                            Log.Information("Nauta session closed.");
                        }
                    });

            return command;
        }
    }
}