// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IViewModelFactory.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.ViewModels.Interfaces;

public interface IViewModelFactory
{
    TViewModel Create<TViewModel>(params object[] parameters)
        where TViewModel : IViewModel;

    Task<TViewModel> CreateAsync<TViewModel>(params object[] parameters)
        where TViewModel : IViewModel;
}