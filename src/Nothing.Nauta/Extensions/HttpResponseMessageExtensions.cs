namespace Nothing.Nauta.Extensions
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Nothing.Nauta.Helpers;

    internal static class HttpResponseMessageExtensions
    {
        public static async Task<string> EnsureGetStringAsync(this HttpResponseMessage httpResponseMessage)
        {
            httpResponseMessage.EnsureSuccessStatusCode();
            var response = await httpResponseMessage.Content.ReadAsStringAsync();
            ResponseProcessors.Process(response);
            return response;
        }
    }
}