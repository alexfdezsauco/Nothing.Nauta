using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Nothing.Nauta.App.Components
{
    using Nothing.Nauta.App.Components.Attributes;
    using Nothing.Nauta.App.ViewModels.Pages;

    public partial class AccountView 
    {
        [Inject]
        [ViewToViewModel]
        public ISnackbar Snackbar { get; set; }

        [Inject]
        [ViewToViewModel]
        public IDialogService DialogService { get; set; }

        [CascadingParameter]
        [ViewToViewModel]
        public IndexViewModel IndexViewModel { get; set; }
    }
}
