using Nothing.Nauta.App.Services.EventArgs;
using Nothing.Nauta.App.Services.Interfaces;

namespace Nothing.Nauta.App.ViewModels.Shared
{
    public class MainLayoutViewModel : ViewModelBase
    {
        private readonly ISessionManager _sessionManager;

        public MainLayoutViewModel(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public override async Task InitializeAsync()
        {
            _sessionManager.StateChanged += OnSessionManagerStateChanged;
            this.IsSessionConnected = await _sessionManager.IsConnectedAsync();
        }

        private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
        {
            this.IsSessionConnected = e.IsConnected;
        }

        public bool IsDrawerOpen
        {
            get => GetPropertyValue<bool>(nameof(IsDrawerOpen));
            set => SetPropertyValue(nameof(IsDrawerOpen), value);
        }

        public bool IsSessionConnected
        {
            get => GetPropertyValue<bool>(nameof(this.IsSessionConnected));
            private set => SetPropertyValue(nameof(this.IsSessionConnected), value);
        }

        public void DrawerToggle()
        {
            IsDrawerOpen = !IsDrawerOpen;
        }
    }
}
