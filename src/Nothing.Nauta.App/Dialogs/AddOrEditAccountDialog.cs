namespace Nothing.Nauta.App.Dialogs
{
    using Microsoft.AspNetCore.Components.Web;
    using Microsoft.AspNetCore.Components;

    using MudBlazor;

    using Nothing.Nauta.App.Data;

    public partial class AddOrEditAccountDialog
    {
        [Parameter]
        public AccountInfo? AccountInfo { get; set; }

        [CascadingParameter]
        private MudDialogInstance? MudDialog { get; set; }

        private MudForm form;

        private bool success;

        private string[] errors;

        private void Cancel(MouseEventArgs arg)
        {
            this.MudDialog!.Cancel();
        }

        private async Task SaveAsync(MouseEventArgs arg)
        {
            await this.form.Validate();

            if (!this.success)
            {
                return;
            }

            this.MudDialog!.Close(true);
        }
    }
}