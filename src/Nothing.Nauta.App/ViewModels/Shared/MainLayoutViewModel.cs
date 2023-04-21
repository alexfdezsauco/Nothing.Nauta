using Nothing.Nauta.App.Services.Interfaces;

namespace Nothing.Nauta.App.ViewModels.Shared
{
    public class MainLayoutViewModel : ViewModelBase
    {
        private readonly ISessionManager sessionManager;

        public MainLayoutViewModel(ISessionManager sessionManager)
        {
            this.sessionManager = sessionManager;
            this.sessionManager.StateChanged += OnSessionManagerStateChanged;
        }

        private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
        {
            IsConnected = e.IsConnected;
        }

        public bool IsDrawerOpen
        {
            get => GetPropertyValue<bool>(nameof(this.IsDrawerOpen));
            set => SetPropertyValue(nameof(this.IsDrawerOpen), value);
        }

        public bool IsConnected
        {
            get => GetPropertyValue<bool>(nameof(IsConnected));
            private set => SetPropertyValue(nameof(IsConnected), value);
        }

        public void DrawerToggle()
        {
            this.IsDrawerOpen = !this.IsDrawerOpen;
        }
    }
}
