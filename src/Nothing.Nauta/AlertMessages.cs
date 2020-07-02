namespace Nothing.Nauta
{
    using System;
    using System.Text.RegularExpressions;

    using Serilog;

    public static class AlertMessages
    {
        private const string AnormalAccountStatus = "Su estado de cuenta es anormal.";

        private const string TimeAdjustmentRequired = "Ha iniciado sesión en una semana. Reajuste el tiempo.";

        private const string UserAlreadyConnected = "El usuario ya está conectado.";

        private const string UserCouldNotBeAuthorized = "No se pudo autorizar al usuario.";

        private const string UserOrPasswordIncorrect = "El nombre de usuario o contraseña son incorrectos.";

        public static void Process(string content)
        {
            var alertRegex = new Regex("alert[(]\"([^\"]+)\"[)];");
            var alertMatch = alertRegex.Match(content);
            if (alertMatch.Success)
            {
                var message = alertMatch.Groups[1].Value.Trim();

                if (message == UserAlreadyConnected)
                {
                    throw new InvalidOperationException("A session is already open");
                }

                if (message == AnormalAccountStatus)
                {
                    throw new InvalidOperationException("Anormal account status");
                }

                if (message == UserOrPasswordIncorrect)
                {
                    throw new UnauthorizedAccessException("Incorrect username or password");
                }

                if (message.StartsWith(UserCouldNotBeAuthorized))
                {
                    throw new UnauthorizedAccessException("User couldn't be authorized");
                }

                if (message == TimeAdjustmentRequired)
                {
                    Log.Warning("Time adjustment is required.");
                }
                else
                {
                    throw new InvalidOperationException(message);
                }
            }
        }
    }
}