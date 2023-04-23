// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteConfirmDialog.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Dialogs
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;
    using MudBlazor;
    using Nothing.Nauta.App.Data;

    public partial class DeleteConfirmDialog
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