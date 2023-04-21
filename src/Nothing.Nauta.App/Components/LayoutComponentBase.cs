namespace Nothing.Nauta.App.Components;

using Microsoft.AspNetCore.Components;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels;

public class LayoutComponentBase<TViewModel> : LayoutComponentBase where TViewModel: IViewModel
{
    [Inject]
    private IViewModelFactory? ViewModelFactory { get; set; }

    public TViewModel? ViewModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (ViewModelFactory is null)
        {
            return;
        }

        ViewModel = ViewModelFactory.Create<TViewModel>();
        ViewModel.PropertyChanged += (sender, args) =>
            {
                InvokeAsync(this.StateHasChanged);
            };

        await ViewModel.InitializeAsync();
    }
}