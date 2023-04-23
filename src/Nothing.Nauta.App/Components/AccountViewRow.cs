// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountViewRow.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Components;

using Microsoft.AspNetCore.Components;

using MudBlazor;

using Nothing.Nauta.App.Components.Attributes;
using Nothing.Nauta.App.ViewModels.Pages;

public partial class AccountViewRow
{
    [Inject]
    [ViewToViewModel]
    public ISnackbar? Snackbar { get; set; }

    [Inject]
    [ViewToViewModel]
    public IDialogService? DialogService { get; set; }

    [CascadingParameter]
    [ViewToViewModel]
    public IndexViewModel? IndexViewModel { get; set; }
}