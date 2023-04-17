namespace Nothing.Nauta.App.Dialogs
{
    using Microsoft.AspNetCore.Components.Web;
    using Microsoft.AspNetCore.Components;

    using MudBlazor;

    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Services.Interfaces;

    public partial class DeleteCorfirmDialog
    {
        [Parameter]
        public AccountInfo? AccountInfo { get; set; }

        [CascadingParameter]
        private MudDialogInstance? MudDialog { get; set; }

        private void Cancel(MouseEventArgs arg)
        {
            this.MudDialog!.Cancel();
        }

        private void Confirm(MouseEventArgs arg)
        {
            this.MudDialog!.Close(true);
        }
    }
}