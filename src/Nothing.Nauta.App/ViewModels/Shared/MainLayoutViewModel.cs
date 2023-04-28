// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainLayoutViewModel.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.ViewModels.Shared
{
    using Nothing.Nauta.App.Services.EventArgs;
    using Nothing.Nauta.App.Services.Interfaces;

    /// <summary>
    /// The main layout view model.
    /// </summary>
    public class MainLayoutViewModel : ViewModelBase
    {
        /// <summary>
        /// The session manager.
        /// </summary>
        private readonly ISessionManager sessionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainLayoutViewModel"/> class.
        /// </summary>
        /// <param name="sessionManager">
        /// The session manager.
        /// </param>
        public MainLayoutViewModel(ISessionManager sessionManager)
        {
            this.sessionManager = sessionManager;
            this.sessionManager.StateChanged += this.OnSessionManagerStateChanged;
        }

        /// <summary>
        /// Gets or sets a value indicating whether is drawer open.
        /// </summary>
        public bool IsDrawerOpen
        {
            get => this.GetPropertyValue<bool>(nameof(this.IsDrawerOpen));
            set => this.SetPropertyValue(nameof(this.IsDrawerOpen), value);
        }

        /// <summary>
        /// Gets a value indicating whether is session connected.
        /// </summary>
        public bool IsSessionConnected
        {
            get => this.GetPropertyValue<bool>(nameof(this.IsSessionConnected));
            private set => this.SetPropertyValue(nameof(this.IsSessionConnected), value);
        }

        /// <summary>
        /// The initialize async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public override async Task InitializeAsync()
        {
            this.IsSessionConnected = await this.sessionManager.IsConnectedAsync();
        }

        /// <summary>
        /// The drawer toggle.
        /// </summary>
        public void DrawerToggle()
        {
            this.IsDrawerOpen = !this.IsDrawerOpen;
        }

        /// <summary>
        /// Called on session manager state changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
        {
            this.IsSessionConnected = e.IsConnected;
        }
    }
}
