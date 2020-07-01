namespace Nothing.Nauta
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using AngleSharp;
    using AngleSharp.Html.Dom;

    public class SessionHandler
    {
        private readonly Uri baseAddress = new Uri("https://secure.etecsa.net:8443/");

        private readonly Regex regex = new Regex("ATTRIBUTE_UUID=([^&]+)", RegexOptions.Compiled);

        public async Task CloseAsync(Dictionary<string, string> sessionData)
        {
            sessionData = new Dictionary<string, string>(sessionData);

            var sessionId = sessionData["JSESSIONID"];
            sessionData.Remove("JSESSIONID");

            sessionData["remove"] = "1";
            sessionData["loggerId"] = $"{sessionData["loggerId"]}+{sessionData["username"]}";

            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = this.baseAddress })
            {
                var content = new FormUrlEncodedContent(sessionData);
                cookieContainer.Add(this.baseAddress, new Cookie("JSESSIONID", sessionId));
                var httpResponseMessage = await client.PostAsync("/LogoutServlet", content);

                httpResponseMessage.EnsureSuccessStatusCode();
            }
        }

        public async Task<Dictionary<string, string>> OpenAsync(string username, string password)
        {
            var browsingContext = BrowsingContext.New(Configuration.Default);
            var cookieContainer = new CookieContainer();

            var handler = new HttpClientHandler { CookieContainer = cookieContainer };
            using (var client = new HttpClient(handler) { BaseAddress = this.baseAddress })
            {
                var content = await client.GetStringAsync("/");

                var cookieCollection = cookieContainer.GetCookies(this.baseAddress);
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

                nameValueCollection["username"] = username;
                nameValueCollection["password"] = password;

                var formUrlEncodedContent = new FormUrlEncodedContent(nameValueCollection);

                var httpResponseMessage = await client.PostAsync("/LoginServlet", formUrlEncodedContent);
                httpResponseMessage.EnsureSuccessStatusCode();

                var sessionData = new Dictionary<string, string>();
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                var match = this.regex.Match(response);

                sessionData.Add("JSESSIONID", cookieCollection["JSESSIONID"]?.Value);
                sessionData.Add("ATTRIBUTE_UUID", match.Groups[1].Value);

                sessionData.Add("CSRFHW", nameValueCollection["CSRFHW"]);
                sessionData.Add("wlanuserip", nameValueCollection["wlanuserip"]);
                sessionData.Add("loggerId", nameValueCollection["loggerId"]);
                sessionData.Add("username", nameValueCollection["username"]);

                return sessionData;
            }
        }
    }
}