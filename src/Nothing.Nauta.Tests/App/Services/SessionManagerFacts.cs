namespace Nothing.Nauta.Tests.App.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Maui.Storage;

    using Moq;

    using Nothing.Nauta.App.Services;
    using Nothing.Nauta.Interfaces;

    using System.Text.Json;

    using FluentAssertions;

    using Nothing.Nauta.App.Services.Interfaces;

    using Xunit;

    public class SessionManagerFacts
    {
        public class The_OpenAsync_Method
        {
            [Fact]
            [Trait(Traits.Category, Category.Unit)]
            public async Task Calls_SecureStorage_SetAsync_Method_With_The_Expected_Params_Async()
            {
                var secureStorageMock = new Mock<ISecureStorage>();
                Dictionary<string, string> deserializedSessionData = null;
                secureStorageMock.Setup(
                    storage => storage.SetAsync(SessionManager.NautaSessionData, It.IsAny<string>())).Callback(
                    (string key, string data) =>
                        {
                            deserializedSessionData = JsonSerializer.Deserialize<Dictionary<string, string>>(data);
                        });

                var sessionHandlerMock = new Mock<ISessionHandler>();
                var sessionData = new Dictionary<string, string>
                                      {
                                          { SessionDataKeys.SessionId, Guid.NewGuid().ToString() },
                                          { SessionDataKeys.UserName, Guid.NewGuid().ToString() },
                                          { SessionDataKeys.Started, DateTime.Now.ToString() }
                                      };

                sessionHandlerMock.Setup(handler => handler.OpenAsync(It.IsAny<string>(), It.IsAny<string>()))
                    .ReturnsAsync(sessionData);

                var sessionManager = new SessionManager(
                    secureStorageMock.Object,
                    sessionHandlerMock.Object,
                    new Mock<ITimeService>().Object);

                await sessionManager.OpenAsync(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

                deserializedSessionData.Should().BeEquivalentTo(sessionData);
            }
        }

        public class The_GetTimeAsync_Method
        {
            public static IEnumerable<object[]> Data()
            {
                var sessionStartedTime = new DateTime(2023, 4, 22, 10, 49, 0);

                yield return new object[]
                                 {
                                     GetSerializedSessionData(sessionStartedTime),
                                     sessionStartedTime.Add(TimeSpan.FromMinutes(2)),
                                     TimeSpan.FromMinutes(3), TimeSpan.FromMinutes(1)
                                 }; 
                
                yield return new object[]
                                 {
                                     GetSerializedSessionData(sessionStartedTime),
                                     sessionStartedTime.Add(TimeSpan.FromMinutes(1)),
                                     TimeSpan.FromMinutes(3), TimeSpan.FromMinutes(2)
                                 };   
                
                yield return new object[]
                                 {
                                     GetSerializedSessionData(sessionStartedTime),
                                     sessionStartedTime.Add(TimeSpan.FromMinutes(1.5)),
                                     TimeSpan.FromMinutes(3), TimeSpan.FromMinutes(1.5)
                                 };
            }

            private static string GetSerializedSessionData(DateTime started)
            {
                return JsonSerializer.Serialize(
                    new Dictionary<string, string>
                        {
                            { SessionDataKeys.Started, started.ToString(SessionManager.StartedTimeFormat) }
                        });
            }

            [Theory]
            [MemberData(nameof(Data))]
            [Trait(Traits.Category, Category.Unit)]
            public async Task Returns_ExpectedValues_Async(string serializedSessionData, DateTime now, TimeSpan expectedTotal, TimeSpan expectedRemainingTime)
            {
                var secureStorageMock = new Mock<ISecureStorage>();
                secureStorageMock.Setup(s => s.GetAsync(SessionManager.NautaSessionData)).ReturnsAsync(serializedSessionData);

                var sessionHandlerMock = new Mock<ISessionHandler>();
                sessionHandlerMock.Setup(handler => handler.RemainingTimeAsync(It.IsAny<Dictionary<string, string>>()))
                    .ReturnsAsync(expectedTotal);

                var timeServiceMock = new Mock<ITimeService>();
                timeServiceMock.Setup(service => service.Now()).Returns(now);

                var sessionManager = new SessionManager(secureStorageMock.Object, sessionHandlerMock.Object, timeServiceMock.Object);
                var (total, remainingTime) = await sessionManager.GetTimeAsync();

                total.Should().Be(expectedTotal);
                remainingTime.Should().Be(expectedRemainingTime);
            }
        }
    }
}
