namespace Nothing.Nauta.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISessionHandler
    {
        Task CloseAsync(Dictionary<string, string> sessionData);

        Task<Dictionary<string, string>> OpenAsync(string username, string password);

        Task<TimeSpan> RemainingTimeAsync(Dictionary<string, string> sessionData);
    }
}