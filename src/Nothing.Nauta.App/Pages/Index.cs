using MudBlazor;

namespace Nothing.Nauta.App.Pages
{
    using Microsoft.AspNetCore.Components;

    public partial class Index
    {
        [Inject]
        public ISnackbar Snackbar { get; set; }

        [Inject]
        public IDialogService DialogService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            if (ViewModel is null)
            {
                return;
            }

            // TODO: Improve this inject automatically. These service can't be injected via constructor.
            ViewModel.Snackbar = Snackbar;
            ViewModel.DialogService = DialogService;
        }
    }
}