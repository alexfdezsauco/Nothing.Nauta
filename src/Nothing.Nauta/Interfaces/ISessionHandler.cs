// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISessionHandler.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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