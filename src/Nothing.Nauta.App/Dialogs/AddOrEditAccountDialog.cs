// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddOrEditAccountDialog.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Dialogs
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;
    using MudBlazor;
    using Nothing.Nauta.App.Data;

    public partial class AddOrEditAccountDialog
    {
        private MudForm form;
        private bool success;
        private string[] errors;
        private InputType passwordInputType = InputType.Password;
        private string passwordInputAdornmentIcon = Icons.Material.Filled.VisibilityOff;

        [Parameter]
        public AccountInfo? AccountInfo { get; set; }

        [CascadingParameter]
        private MudDialogInstance? MudDialog { get; set; }

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

        private void ToggleInput()
        {
            if (this.passwordInputType == InputType.Password)
            {
                this.passwordInputType = InputType.Text;
                this.passwordInputAdornmentIcon = Icons.Material.Filled.Visibility;
            }
            else
            {
                this.passwordInputType = InputType.Password;
                this.passwordInputAdornmentIcon = Icons.Material.Filled.VisibilityOff;
            }
        }
    }
}