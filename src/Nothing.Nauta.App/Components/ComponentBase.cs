﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComponentBase.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Components
{
    using System.ComponentModel;

    using Microsoft.AspNetCore.Components;
    using Nothing.Nauta.App.Components.Extensions;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.App.ViewModels.Interfaces;

    public class ComponentBase<TViewModel> : Blorc.Components.BlorcComponentBase
        where TViewModel : class, IViewModel
    {
        public ComponentBase()
        {
            this.PropertyChanged += this.OnPropertyChanged;
        }

        [Parameter]
        public TViewModel? ViewModel
        {
            get => this.GetPropertyValue<TViewModel>(nameof(this.ViewModel));
            set => this.SetPropertyValue(nameof(this.ViewModel), value);
        }

        [Inject]
        private IViewModelFactory? ViewModelFactory { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await this.InitializeViewModelAsync();
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(this.ViewModel))
            {
                this.InvokeAsync(async () =>
                    {
                        await this.InitializeViewModelAsync();
                        this.StateHasChanged();
                    });
            }
        }

        private async Task InitializeViewModelAsync()
        {
            if (this.ViewModelFactory is null)
            {
                return;
            }

            if (this.ViewModel is null)
            {
                this.ViewModel = this.ViewModelFactory.Create<TViewModel>();
            }

            this.MapViewToViewModelProperties();
            this.ViewModel.PropertyChanged += this.OnViewModelPropertyChanged;
            this.ViewModel.InvokeAsync = this.InvokeAsync;

            await this.ViewModel.InitializeAsync();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            this.InvokeAsync(this.StateHasChanged);
        }
    }
}