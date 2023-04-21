namespace Nothing.Nauta.App.Components;

using System.ComponentModel;

using Microsoft.AspNetCore.Components;
using Nothing.Nauta.App.Components.Extensions;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels.Interfaces;

public class ComponentBase<TViewModel> : Blorc.Components.BlorcComponentBase where TViewModel : class, IViewModel
{
    public ComponentBase()
    {
        PropertyChanged += OnPropertyChanged;
    }

    private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ViewModel))
        {
            InvokeAsync(() => StateHasChanged());
        }
    }

    [Inject]
    private IViewModelFactory? ViewModelFactory { get; set; }

    [Parameter]
    public TViewModel? ViewModel
    {
        get => GetPropertyValue<TViewModel>(nameof(ViewModel));
        set => SetPropertyValue(nameof(ViewModel), value);
    }

    protected override async Task OnInitializedAsync()
    {
        await InitializeViewModelAsync();
    }

    private async Task InitializeViewModelAsync()
    {
        if (ViewModelFactory is null)
        {
            return;
        }

        if (ViewModel is null)
        {
            ViewModel = ViewModelFactory.Create<TViewModel>();
        }

        this.MapViewToViewModelProperties();
        ViewModel.PropertyChanged += this.OnViewModelPropertyChanged;
        ViewModel.InvokeAsync = InvokeAsync;

        await ViewModel.InitializeAsync();
    }

    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }
}