// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Index.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Pages
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Components;
    using MudBlazor;

    using Nothing.Nauta.App.Authorization;
    using Nothing.Nauta.App.Components.Attributes;

    [Authorize(Policy = Policies.Fingerprint)]
    public partial class Index
    {
        [Inject]
        [ViewToViewModel]
        public ISnackbar? Snackbar { get; set; }

        [Inject]
        [ViewToViewModel]
        public IDialogService? DialogService { get; set; }
    }
}