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
            IsConnected = await _sessionManager.IsConnectedAsync();
        }

        private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
        {
            IsConnected = e.IsConnected;
        }

        public bool IsDrawerOpen
        {
            get => GetPropertyValue<bool>(nameof(IsDrawerOpen));
            set => SetPropertyValue(nameof(IsDrawerOpen), value);
        }

        public bool IsConnected
        {
            get => GetPropertyValue<bool>(nameof(IsConnected));
            private set => SetPropertyValue(nameof(IsConnected), value);
        }

        public void DrawerToggle()
        {
            IsDrawerOpen = !IsDrawerOpen;
        }
    }
}
