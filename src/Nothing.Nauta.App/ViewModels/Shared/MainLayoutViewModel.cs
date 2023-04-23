// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainLayoutViewModel.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.ViewModels.Shared
{
    using Nothing.Nauta.App.Services.EventArgs;
    using Nothing.Nauta.App.Services.Interfaces;

    public class MainLayoutViewModel : ViewModelBase
    {
        private readonly ISessionManager sessionManager;

        public MainLayoutViewModel(ISessionManager sessionManager)
        {
            this.sessionManager = sessionManager;
        }

        public bool IsDrawerOpen
        {
            get => this.GetPropertyValue<bool>(nameof(this.IsDrawerOpen));
            set => this.SetPropertyValue(nameof(this.IsDrawerOpen), value);
        }

        public bool IsSessionConnected
        {
            get => this.GetPropertyValue<bool>(nameof(this.IsSessionConnected));
            private set => this.SetPropertyValue(nameof(this.IsSessionConnected), value);
        }

        public override async Task InitializeAsync()
        {
            this.sessionManager.StateChanged += this.OnSessionManagerStateChanged;
            this.IsSessionConnected = await this.sessionManager.IsConnectedAsync();
        }

        public void DrawerToggle()
        {
            this.IsDrawerOpen = !this.IsDrawerOpen;
        }

        private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
        {
            this.IsSessionConnected = e.IsConnected;
        }
    }
}
