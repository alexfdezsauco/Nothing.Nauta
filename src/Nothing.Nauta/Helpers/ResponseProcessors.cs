namespace Nothing.Nauta.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using Nothing.Nauta.Helpers.Interfaces;

    using Serilog;

    internal static class ResponseProcessors
    {
        private const string AnormalAccountStatus = "Su estado de cuenta es anormal.";

        private const string TimeAdjustmentRequired = "Ha iniciado sesión en una semana. Reajuste el tiempo.";

        private const string UserAlreadyConnected = "El usuario ya está conectado.";

        private const string UserCouldNotBeAuthorized = "No se pudo autorizar al usuario.";

        private const string UserOrPasswordIncorrect = "El nombre de usuario o contraseña son incorrectos.";

        private static readonly List<IProcessor> Processors = new List<IProcessor>();

        /// <summary>
        ///     Initializes static members of the <see cref="ResponseProcessors" /> class.
        /// </summary>
        static ResponseProcessors()
        {
            Processors.Add(
                new TextProcessor(
                    s => s == "errorop",
                    s => throw new InvalidOperationException(
                             "The operation could be executed. It could be caused by an expired session.")));
            Processors.Add(
                new TextProcessor(
                    s => s == "logoutcallback('FAILURE');",
                    s => throw new InvalidOperationException(
                             "The operation could be executed. It could be caused by an expired session.")));

            var alertRegex = new Regex("alert[(]\"([^\"]+)\"[)];");
            Processors.Add(
                new RegexProcessor(
                    alertRegex,
                    groupPredicate: group => group.Index == 1 && group.Value.Trim() == UserAlreadyConnected,
                    action: s => throw new InvalidOperationException("A session is already open")));

            Processors.Add(
                new RegexProcessor(
                    alertRegex,
                    groupPredicate: group => group.Index == 1 && group.Value.Trim() == AnormalAccountStatus,
                    action: s => throw new InvalidOperationException("Anormal account status")));

            Processors.Add(
                new RegexProcessor(
                    alertRegex,
                    groupPredicate: group => group.Index == 1 && group.Value.Trim() == UserOrPasswordIncorrect,
                    action: s => throw new UnauthorizedAccessException("Incorrect username or password")));

            Processors.Add(
                new RegexProcessor(
                    alertRegex,
                    groupPredicate:
                    group => group.Index == 1 && group.Value.Trim().StartsWith(UserCouldNotBeAuthorized),
                    action: s => throw new UnauthorizedAccessException("User couldn't be authorized")));

            Processors.Add(
                new RegexProcessor(
                    alertRegex,
                    groupPredicate: group => group.Index == 1 && group.Value.Trim() == TimeAdjustmentRequired,
                    action: s => Log.Warning("Time adjustment is required.")));

            // This is the default processor.
            Processors.Add(
                new RegexProcessor(
                    alertRegex,
                    groupPredicate: group => group.Index == 1 && !string.IsNullOrWhiteSpace(group.Value.Trim()),
                    action: s => throw new InvalidOperationException(s)));
        }

        public static async Task Process(string content)
        {
            foreach (var processor in Processors)
            {
                await processor.Execute(content);
            }
        }
    }
}