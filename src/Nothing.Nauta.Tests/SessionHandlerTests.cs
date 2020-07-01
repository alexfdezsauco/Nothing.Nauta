namespace Nauta.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Newtonsoft.Json;

    using Nothing.Nauta;

    [TestClass]
    [TestCategory("Demo Usage")]
    public class SessionHandlerTests
    {
        [TestMethod]
        public async Task Login()
        {
            var session = new SessionHandler();
            var sessionData = await session.OpenAsync("username", "password");
            await File.WriteAllTextAsync("session.json", JsonConvert.SerializeObject(sessionData, Formatting.Indented));
        }

        [TestMethod]
        public async Task Logout()
        {
            var content = await File.ReadAllTextAsync("session.json");
            var sessionData = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
            var sessionHandler = new SessionHandler();
            await sessionHandler.CloseAsync(sessionData);
        }

        [TestMethod]
        public async Task Time()
        {
            var content = await File.ReadAllTextAsync("session.json");
            var sessionData = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
            
            var sessionHandler = new SessionHandler();
            await sessionHandler.RemainingTimeAsync(sessionData);
        }
    }
}