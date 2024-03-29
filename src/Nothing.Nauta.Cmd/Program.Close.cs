﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.Close.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
                        var sessionFile = FilesHelper.GetSessionFile();
                        Log.Information("Closing Nauta session...");

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
                            // TODO: Improve this
                            var policy = Policy.Handle<HttpRequestException>().WaitAndRetryForeverAsync(
                                retryAttempt => TimeSpan.FromSeconds(5),
                                (exception, retry, timeSpan) =>
                                    {
                                        Log.Error(exception, "Error closing Nauta session. Will retry in {TimeSpan}.", timeSpan);
                                    });

                            DateTime startDateTime = default;
                            var isTimeAvailable = sessionData.TryGetValue(SessionDataKeys.Started, out var started)
                                                  && DateTime.TryParse(started, out startDateTime);

                            var sessionHandler = new SessionHandler();

                            var remainingTime = await policy.ExecuteAsync(() => sessionHandler.RemainingTimeAsync(sessionData));

                            await policy.ExecuteAsync(() => sessionHandler.CloseAsync(sessionData));
                            var endDateTime = DateTime.Now;

                            try
                            {
                                File.Delete(sessionFile.FullName);
                            }
                            catch (Exception e)
                            {
                                Log.Error(e, "Error deleting persisted session");
                            }

                            Log.Information(
                                "Remaining Time: '{RemainingTime}'.",
                                $"{(int)remainingTime.TotalHours}hrs {remainingTime:mm}mn {remainingTime:ss}sec");

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
                        else
                        {
                            Log.Information("This command requires an open session. Open a nauta session first with open command.");
                        }
                    });

            return command;
        }
    }
}