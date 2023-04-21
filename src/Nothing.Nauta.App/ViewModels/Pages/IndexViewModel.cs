namespace Nothing.Nauta.App.ViewModels.Pages;

using Force.DeepCloner;

using Microsoft.Maui.Controls.Internals;

using MudBlazor;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Extensions;
using Nothing.Nauta.App.Dialogs;
using Nothing.Nauta.App.Services;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels;

public class IndexViewModel : ViewModelBase
{
    private readonly IAccountManagement _accountManagement;
    private readonly ISessionManager _sessionManager;
    private readonly IViewModelFactory _viewModelFactory;

    public IndexViewModel(IAccountManagement accountManagement, ISessionManager sessionManager, IViewModelFactory viewModelFactory)
    {
        _accountManagement = accountManagement;
        _sessionManager = sessionManager;
        _viewModelFactory = viewModelFactory;
    }

    public override async Task InitializeAsync()
    {
        _sessionManager.StateChanged += OnSessionManagerStateChanged;
        IsConnected = await _sessionManager.IsConnectedAsync();

        await ReloadAsync();
    }

    private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
    {
        IsConnected = e.IsConnected;
    }

    public async Task ReloadAsync()
    {
        this.IsReloading = true;

        try
        {
            if (this.Accounts is not null)
            {
                foreach (var accountViewModel in this.Accounts)
                {
                    accountViewModel.Dispose();
                }
            }

            var accounts = new List<AccountViewModel>();
            foreach (var accountInfo in await _accountManagement!.ListAsync())
            {
                var accountViewModel = await _viewModelFactory.CreateAsync<AccountViewModel>(accountInfo);
                // TODO: Improve this later.
                accountViewModel.InvokeAsync = InvokeAsync;
                accountViewModel.PropertyChanged += (sender, args) =>
                    {
                        OnPropertyChanged(nameof(Accounts));
                    };

                accounts.Add(accountViewModel);
            }

            Accounts ??= new List<AccountViewModel>();
            Accounts.Clear();
            Accounts.AddRange(accounts);
        }
        finally
        {
            this.IsReloading = false;
        }
    }

    public List<AccountViewModel>? Accounts
    {
        get => GetPropertyValue<List<AccountViewModel>>(nameof(Accounts));
        private set => SetPropertyValue(nameof(Accounts), value);
    }

    public bool IsConnected
    {
        get => GetPropertyValue<bool>(nameof(IsConnected));
        private set => SetPropertyValue(nameof(IsConnected), value);
    }
    public bool IsReloading
    {
        get => GetPropertyValue<bool>(nameof(IsReloading));
        private set => SetPropertyValue(nameof(IsReloading), value);
    }

    public bool IsOverlayVisible
    {
        get => GetPropertyValue<bool>(nameof(IsOverlayVisible));
        private set => SetPropertyValue(nameof(IsOverlayVisible), value);
    }

    public ISnackbar Snackbar { get; set; }

    public IDialogService DialogService { get; set; }


    public bool IsSwitchDisable(AccountViewModel context)
    {
        return !context.IsConnected && IsConnected;
    }

    public bool IsEditDisable(AccountViewModel context)
    {
        return context.IsConnected;
    }

    public bool IsDeleteDisable(AccountViewModel context)
    {
        return context.IsConnected;
    }

    public async Task EditAsync(AccountViewModel context)
    {
        var accountInfo = context.AccountInfo.DeepClone();

        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(AddOrEditAccountDialog.AccountInfo), accountInfo }
                                   };

        var dialogReference = await this.DialogService.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await _accountManagement.UpdateAsync(accountInfo);
            await ReloadAsync();
        }
    }

    public async Task DeleteAsync(AccountViewModel context)
    {
        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(DeleteConfirmDialog.AccountInfo), context.AccountInfo }
                                   };

        var dialogReference = await this.DialogService!.ShowAsync<DeleteConfirmDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await _accountManagement!.RemoveAsync(context.AccountInfo);
            await ReloadAsync();
        }
    }

    public async Task AddAccountAsync()
    {
        var accountInfo = new AccountInfo();
        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(DeleteConfirmDialog.AccountInfo), accountInfo }
                                   };

        var dialogReference = await this.DialogService.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await _accountManagement.AddAsync(accountInfo);
            await ReloadAsync();
        }
    }

    public async Task CheckedChangedAsync(AccountViewModel context)
    {
        if (!context.IsConnected)
        {
            await BackgroundRunAsync(() => OpenAsync(context), ReloadAsync);
        }
        else
        {
            await BackgroundRunAsync(CloseAsync, ReloadAsync, ForceConnectionCloseAsync);
        }
    }

    private async Task CloseAsync()
    {
        await _sessionManager.CloseAsync();
    }

    private async Task OpenAsync(AccountViewModel context)
    {
        await _sessionManager.OpenAsync(context.AccountInfo.GetUserName(), context.AccountInfo.Password);
    }

    private async Task ForceConnectionCloseAsync()
    {
        var dialogReference = await this.DialogService.ShowAsync<ForceConnectionCloseConfirmDialog>(string.Empty);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await _sessionManager.ForceCloseAsync();
            await ReloadAsync();
        }
    }

    protected Task BackgroundRunAsync(Func<Task> task, Func<Task>? onFinishTask = null, Func<Task>? onErrorTask = null)
    {
        IsOverlayVisible = true;

        _ = Task.Run(
            async () =>
                {
                    Exception? exception = null;
                    try
                    {
                        await task();
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                    }
                    finally
                    {
                        IsOverlayVisible = false;

                        _ = InvokeAsync?.Invoke(
                            async () =>
                                {
                                    if (exception is not null)
                                    {
                                        Snackbar?.Add(exception.Message, Severity.Error);
                                        if (onErrorTask is not null)
                                        {
                                            await onErrorTask();
                                        }
                                    }

                                    if (onFinishTask is not null)
                                    {
                                        await onFinishTask();
                                    }
                                });
                    }
                        
                });

        return Task.CompletedTask;
    }
}