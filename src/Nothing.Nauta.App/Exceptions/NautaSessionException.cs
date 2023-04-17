namespace Nothing.Nauta.App.Exceptions;

public class NautaSessionException : Exception
{
    public NautaSessionException(string message, Exception exception)
        : base(message, exception)
    {
    }
}