namespace Nothing.Nauta.Tests.App.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Moq;

    using FluentAssertions;

    using Microsoft.Maui.Devices;

    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.App.ViewModels.Components;

    using Xunit;

    public class AccountViewModelFacts
    {
        public class The_RemainingTimeProgressBarColor_Property
        {
            public static IEnumerable<object[]> Data()
            {
                yield return new object[]
                                 {
                                     TimeSpan.FromMinutes(6),
                                     MudBlazor.Color.Success,
                                 }; 
                
                yield return new object[]
                                 {
                                     TimeSpan.FromMinutes(4),
                                     MudBlazor.Color.Warning
                                 };   
                
                yield return new object[]
                                 {
                                     TimeSpan.FromMinutes(0.5),
                                     MudBlazor.Color.Error
                                 };
            }

            [Theory]
            [MemberData(nameof(Data))]
            [Trait(Traits.Category, Category.Unit)]
            public async Task Returns_ExpectedValues_Async(TimeSpan remainingTime, MudBlazor.Color expectedColor)
            {
                var sessionManagerMock = new Mock<ISessionManager>();

                var accountManagementMock = new Mock<IAccountManagement>();
                var deviceDisplayMock = new Mock<IDeviceDisplay>();

                var accountViewModel = new AccountViewModel(new AccountInfo(), sessionManagerMock.Object, accountManagementMock.Object, deviceDisplayMock.Object);

                var propertyInfo = typeof(AccountViewModel).GetProperty(nameof(AccountViewModel.RemainingTime));
                propertyInfo?.SetValue(accountViewModel, remainingTime);

                accountViewModel.RemainingTimeProgressBarColor.Should().Be(expectedColor);
            }
        }
    }
}
