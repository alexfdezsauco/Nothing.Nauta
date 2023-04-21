namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.ViewModels;

public interface IViewModelFactory
{
    TViewModel Create<TViewModel>(params object[] parameters) where TViewModel : IViewModel;

    Task<TViewModel> CreateAsync<TViewModel>(params object[] parameters) where TViewModel : IViewModel;
}