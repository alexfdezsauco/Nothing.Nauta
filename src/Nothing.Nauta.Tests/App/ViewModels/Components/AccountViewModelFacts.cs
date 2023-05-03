// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountViewModelFacts.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.Tests.App.ViewModels.Components
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Microsoft.Maui.Devices;

    using Moq;

    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Data.Services.Interfaces;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.App.ViewModels.Components;

    using Xunit;

    public class AccountViewModelFacts
    {
        public class The_RemainingTimeProgressBarColor_Property
        {
            public static IEnumerable<object[]> Data()
            {
                yield return new object[] { TimeSpan.FromMinutes(6), false, MudBlazor.Color.Dark };

                yield return new object[] { TimeSpan.FromMinutes(6), true, MudBlazor.Color.Success };

                yield return new object[] { TimeSpan.FromMinutes(4), true, MudBlazor.Color.Warning };

                yield return new object[] { TimeSpan.FromMinutes(0.5), true, MudBlazor.Color.Error };
            }

            [Theory]
            [MemberData(nameof(Data))]
            [Trait(Traits.Category, Category.Unit)]
            public async Task Returns_ExpectedValues_Async(TimeSpan remainingTime, bool isConnected, MudBlazor.Color expectedColor)
            {
                var sessionManagerMock = new Mock<ISessionManager>();

                var accountManagementMock = new Mock<IAccountRepository>();
                var deviceDisplayMock = new Mock<IDeviceDisplay>();

                var accountViewModel = new AccountViewModel(new AccountInfo(), sessionManagerMock.Object, accountManagementMock.Object, deviceDisplayMock.Object);

                var remainingTimePropertyInfo = typeof(AccountViewModel).GetProperty(nameof(AccountViewModel.RemainingTime));
                remainingTimePropertyInfo?.SetValue(accountViewModel, remainingTime);

                var isConnectedPropertyInfo = typeof(AccountViewModel).GetProperty(nameof(AccountViewModel.IsConnected));
                isConnectedPropertyInfo?.SetValue(accountViewModel, isConnected);

                accountViewModel.RemainingTimeProgressBarColor.Should().Be(expectedColor);
            }
        }
    }
}
