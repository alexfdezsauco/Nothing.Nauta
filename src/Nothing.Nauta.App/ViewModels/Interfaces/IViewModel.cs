namespace Nothing.Nauta.App.ViewModels.Interfaces;

public interface IViewModel : Blorc.MVVM.IViewModel
{
    Task InitializeAsync();

    Func<Action, Task> InvokeAsync { get; set; }
}