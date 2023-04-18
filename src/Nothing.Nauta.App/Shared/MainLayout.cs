namespace Nothing.Nauta.App.Shared
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;

    using MudBlazor;

    using Nothing.Nauta.App.Dialogs;

    public partial class MainLayout
    {
        private bool _drawerOpen = true;

        [Inject]
        public IDialogService? DialogService { get; set; }

        private void DrawerToggle()
        {
            this._drawerOpen = !this._drawerOpen;
        }
    }
}
