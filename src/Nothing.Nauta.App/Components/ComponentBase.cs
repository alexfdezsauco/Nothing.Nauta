namespace Nothing.Nauta.App.Components;

using Microsoft.AspNetCore.Components;
using Nothing.Nauta.App.Components.Extensions;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels.Interfaces;

public class ComponentBase<TViewModel> : ComponentBase where TViewModel : IViewModel
{
    [Inject]
    private IViewModelFactory? ViewModelFactory { get; set; }

    [Parameter]
    public TViewModel? ViewModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await this.InitializeViewModelAsync();
    }

    private async Task InitializeViewModelAsync()
    {
        if (this.ViewModelFactory is null)
        {
            return;
        }

        if (this.ViewModel is null)
        {
            this.ViewModel = this.ViewModelFactory.Create<TViewModel>();
        }

        this.MapViewToViewModelProperties();
        this.ViewModel.PropertyChanged += (sender, args) => { this.InvokeAsync(this.StateHasChanged); };

        this.ViewModel.InvokeAsync = this.InvokeAsync;

        await this.ViewModel.InitializeAsync();
    }
}