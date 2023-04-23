namespace Nothing.Nauta
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using AngleSharp;
    using AngleSharp.Html.Dom;

    using Nothing.Nauta.Extensions;
    using Nothing.Nauta.Interfaces;

    public class SessionHandler : ISessionHandler
    {
        private static readonly Uri BaseAddress = new Uri("https://secure.etecsa.net:8443/");

        private static readonly TimeSpan Timeout = TimeSpan.FromSeconds(5);

        public async Task CloseAsync(Dictionary<string, string> sessionData)
        {
            sessionData = new Dictionary<string, string>(sessionData);

            var sessionId = sessionData[SessionDataKeys.SessionId];
            sessionData.Remove(SessionDataKeys.SessionId);
            sessionData.Remove(SessionDataKeys.Started);

            sessionData["remove"] = "1";
            sessionData[SessionDataKeys.LoggerId] = $"{sessionData[SessionDataKeys.LoggerId]}+{sessionData[SessionDataKeys.UserName]}";

            var cookieContainer = new CookieContainer();
            using var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer
            };

            using var client = new HttpClient(handler)
            {
                BaseAddress = BaseAddress,
                Timeout = Timeout
            };

            var content = new FormUrlEncodedContent(sessionData);
            cookieContainer.Add(BaseAddress, new Cookie(SessionDataKeys.SessionId, sessionId));
            var httpResponseMessage = await client.PostAsync("/LogoutServlet", content);
            await httpResponseMessage.EnsureGetStringAsync();
        }

        public async Task<Dictionary<string, string>> OpenAsync(string username, string password)
        {
            var browsingContext = BrowsingContext.New(Configuration.Default);

            var cookieContainer = new CookieContainer();
            using var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer
            };

            using var client = new HttpClient(handler)
            {
                BaseAddress = BaseAddress,
                Timeout = Timeout
            };

            var content = await client.GetStringAsync("/");
            var cookieCollection = cookieContainer.GetCookies(BaseAddress);
            var document = await browsingContext.OpenAsync(req => req.Content(content));

            var elementById = document.GetElementById("formulario");

            var nameValueCollection = new Dictionary<string, string>();
            foreach (var element in elementById.Children)
            {
                if (element is IHtmlInputElement inputElement && inputElement.Type == "hidden")
                {
                    nameValueCollection.Add(inputElement.Name, inputElement.Value);
                }
            }

            nameValueCollection[SessionDataKeys.UserName] = username;
            nameValueCollection["password"] = password;

            var formUrlEncodedContent = new FormUrlEncodedContent(nameValueCollection);

            var httpResponseMessage = await client.PostAsync("/LoginServlet", formUrlEncodedContent);
            var response = await httpResponseMessage.EnsureGetStringAsync();

            var startDateTime = DateTime.Now;
            var sessionData = new Dictionary<string, string>();

            var regex = new Regex("ATTRIBUTE_UUID=([^&]+)");
            var match = regex.Match(response);

            sessionData.Add(SessionDataKeys.SessionId, cookieCollection[SessionDataKeys.SessionId]?.Value);
            sessionData.Add(SessionDataKeys.AttributeId, match.Groups[1].Value);

            sessionData.Add(SessionDataKeys.CSRFHW, nameValueCollection[SessionDataKeys.CSRFHW]);
            sessionData.Add(SessionDataKeys.WLANUserIp, nameValueCollection[SessionDataKeys.WLANUserIp]);

            sessionData.Add(SessionDataKeys.LoggerId, nameValueCollection[SessionDataKeys.LoggerId]);
            sessionData.Add(SessionDataKeys.UserName, nameValueCollection[SessionDataKeys.UserName]);
            sessionData.Add(SessionDataKeys.Started, startDateTime.ToString(CultureInfo.InvariantCulture));

            return sessionData;
        }

        public async Task<TimeSpan> RemainingTimeAsync(Dictionary<string, string> sessionData)
        {
            sessionData = new Dictionary<string, string>(sessionData);

            var sessionId = sessionData[SessionDataKeys.SessionId];
            sessionData.Remove(SessionDataKeys.SessionId);
            sessionData.Remove(SessionDataKeys.Started);

            sessionData["op"] = "getLeftTime";
            sessionData[SessionDataKeys.LoggerId] = $"{sessionData[SessionDataKeys.LoggerId]}+{sessionData[SessionDataKeys.UserName]}";

            var cookieContainer = new CookieContainer();
            using var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer
            };

            using var httpClient = new HttpClient(handler)
            {
                BaseAddress = BaseAddress,
                Timeout = Timeout
            };

            var content = new FormUrlEncodedContent(sessionData);
            cookieContainer.Add(BaseAddress, new Cookie(SessionDataKeys.SessionId, sessionId));
            var httpResponseMessage = await httpClient.PostAsync("/EtecsaQueryServlet", content);
            var response = await httpResponseMessage.EnsureGetStringAsync();
            var responseParts = response.Split(':');
            for (var i = 0; i < responseParts.Length; i++)
            {
                responseParts[i] = responseParts[i].TrimStart('0');
                if (responseParts[i].Length == 0)
                {
                    responseParts[i] = "0";
                }
            }

            return new TimeSpan(
                int.Parse(responseParts[0]),
                int.Parse(responseParts[1]),
                int.Parse(responseParts[2]));
        }
    }
}