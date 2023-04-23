// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SessionHandlerTests.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nauta.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using Nothing.Nauta;
    using Nothing.Nauta.Tests;

    using Xunit;

    public class SessionHandlerTests
    {
        [Fact]
        [Trait(Traits.Category, Category.Development)]
        public async Task Login()
        {
            var session = new SessionHandler();
            var sessionData = await session.OpenAsync("username", "password");
            await File.WriteAllTextAsync("session.json", JsonConvert.SerializeObject(sessionData, Formatting.Indented));
        }

        [Fact]
        [Trait(Traits.Category, Category.Development)]
        public async Task Logout()
        {
            var content = await File.ReadAllTextAsync("session.json");
            var sessionData = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
            var sessionHandler = new SessionHandler();
            await sessionHandler.CloseAsync(sessionData);
        }

        [Fact]
        [Trait(Traits.Category, Category.Development)]
        public async Task Time()
        {
            var content = await File.ReadAllTextAsync("session.json");
            var sessionData = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

            var sessionHandler = new SessionHandler();
            await sessionHandler.RemainingTimeAsync(sessionData);
        }
    }
}