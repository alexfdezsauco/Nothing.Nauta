// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeService.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services;

using Nothing.Nauta.App.Services.Interfaces;

public class TimeService : ITimeService
{
    public DateTime Now()
    {
        return DateTime.Now;
    }
}