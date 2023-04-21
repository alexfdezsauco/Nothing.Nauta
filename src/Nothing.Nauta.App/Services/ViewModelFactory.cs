using Nothing.Nauta.App.Services.Interfaces;

namespace Nothing.Nauta.App.Services;

using Nothing.Nauta.App.ViewModels.Interfaces;

public class ViewModelFactory : IViewModelFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ViewModelFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public TViewModel Create<TViewModel>(params object[] parameters)
        where TViewModel : IViewModel
    {
        return ActivatorUtilities.CreateInstance<TViewModel>(_serviceProvider, parameters);
    }

    public async Task<TViewModel> CreateAsync<TViewModel>(params object[] parameters)
        where TViewModel : IViewModel
    {
        var viewModel = ActivatorUtilities.CreateInstance<TViewModel>(_serviceProvider, parameters);
        await viewModel.InitializeAsync();
        return viewModel;
    }
}