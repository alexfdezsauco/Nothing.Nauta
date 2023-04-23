// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IViewModel.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.ViewModels.Interfaces;

public interface IViewModel : Blorc.MVVM.IViewModel
{
    Func<Action, Task> InvokeAsync { get; set; }

    Task InitializeAsync();
}