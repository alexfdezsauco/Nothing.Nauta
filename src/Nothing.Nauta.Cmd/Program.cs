namespace Nothing.Nauta.Cmd
{
    using System.CommandLine;
    using System.CommandLine.Builder;
    using System.CommandLine.Help;
    using System.CommandLine.Invocation;
    using System.CommandLine.Parsing;
    using System.Threading.Tasks;

    using Microsoft.Extensions.DependencyInjection;

    using Serilog;

    internal static partial class Program
    {
        private static Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();

            var serviceCollection = new ServiceCollection();

            var command = new RootCommand { Description = "Nauta command line tool." };

            command.AddCommand(CreateCredentialsCommand());
            command.AddCommand(CreateOpenCommand());
            command.AddCommand(CreateCloseCommand());
            command.AddCommand(CreateTimeCommand());

            // Show commandline help unless a subcommand was used.
            command.Handler = CommandHandler.Create<IHelpBuilder>(
                help =>
                    {
                        help.Write(command);
                        return 1;
                    });

            var builder = new CommandLineBuilder(command);
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