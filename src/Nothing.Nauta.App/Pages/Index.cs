using MudBlazor;

namespace Nothing.Nauta.App.Pages
{
    using Microsoft.AspNetCore.Components;

    using Nothing.Nauta.App.Components.Attributes;

    public partial class Index
    {
        [Inject]
        [ViewToViewModel]
        public ISnackbar? Snackbar { get; set; }

        [Inject]
        [ViewToViewModel]
        public IDialogService? DialogService { get; set; }
    }
}