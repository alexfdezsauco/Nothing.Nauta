// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LayoutComponentBase.cs" company="Stone Assemblies">
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

    public class LayoutComponentBase<TViewModel> : Blorc.Components.BlorcLayoutComponentBase
        where TViewModel : IViewModel
    {
        public LayoutComponentBase()
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
                this.InvokeAsync(this.StateHasChanged);
            }
        }

        private async Task InitializeViewModelAsync()
        {
            if (this.ViewModelFactory is null)
            {
                return;
            }

            this.ViewModel = this.ViewModelFactory.Create<TViewModel>();
            this.MapViewToViewModelProperties();
            this.ViewModel.PropertyChanged += this.OnViewModelPropertyChanged;

            await this.ViewModel.InitializeAsync();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            this.InvokeAsync(this.StateHasChanged);
        }
    }
}