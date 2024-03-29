﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.Cmd
{
    using System.CommandLine;
    using System.CommandLine.Builder;
    using System.CommandLine.Help;
    using System.CommandLine.Invocation;
    using System.CommandLine.Parsing;
    using System.Threading.Tasks;

    using Serilog;

    internal static partial class Program
    {
        private static Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();

            var command = new RootCommand { Description = "Nauta command line tool." };

            command.AddCommand(CreateCredentialsCommand());
            command.AddCommand(CreateOpenCommand());
            command.AddCommand(CreateCloseCommand());
            command.AddCommand(CreateTimeCommand());

            // Show commandline help unless a sub-command was used.
            command.Handler = CommandHandler.Create<IHelpBuilder>(
                help =>
                    {
                        help.Write(command);
                        return 1;
                    });

            var builder = new CommandLineBuilder(command);
            builder.UseExceptionHandler(
                (exception, context) =>
                    {
                        Log.Error(exception, "Error executing command '{command}'.", context.ParseResult.CommandResult.Token.Value);
                    });

            builder.UseHelp();
            builder.UseVersionOption();
            builder.UseDebugDirective();
            builder.UseParseErrorReporting();
            builder.ParseResponseFileAs(ResponseFileHandling.ParseArgsAsSpaceSeparated);
            builder.CancelOnProcessTermination();

            var parser = builder.Build();
            return parser.InvokeAsync(args);
        }
    }
}