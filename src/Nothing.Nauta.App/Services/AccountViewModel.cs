namespace Nothing.Nauta.App.Services;

using System.Timers;

using Force.DeepCloner;

using MudBlazor;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Dialogs;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels;
using Nothing.Nauta.App.ViewModels.Pages;

public class AccountViewModel : ViewModelBase, IDisposable
{
    private readonly ISessionManager _sessionManager;
    private readonly IAccountManagement _accountManagement;
    private readonly Timer _timer = new Timer(1000);

    public AccountViewModel(AccountInfo accountInfo, ISessionManager sessionManager, IAccountManagement accountManagement)
    {
        AccountInfo = accountInfo;
        _sessionManager = sessionManager;
        _accountManagement = accountManagement;

        _timer.Elapsed += async (sender, args) =>
            {
                IsConnected = await _sessionManager.IsConnectedAsync(AccountInfo);
                if (!IsConnected)
                {
                    _timer.Enabled = false;
                }
                else
                {
                    RemainingTime = await _sessionManager.GetRemainingTimeAsync();
                }
            };
    }

    public AccountInfo AccountInfo
    {
        get => GetPropertyValue<AccountInfo>(nameof(AccountInfo));
        private set => SetPropertyValue(nameof(AccountInfo), value);
    }

    public override async Task InitializeAsync()
    {
        _sessionManager.StateChanged += this.OnSessionManagerStateChanged;
        await this.UpdateConnectionStatusAsync();
    }

    private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
    {
        InvokeAsync?.Invoke(async () => await this.UpdateConnectionStatusAsync()) ;
    }

    private async Task UpdateConnectionStatusAsync()
    {
        this.IsConnected = await this._sessionManager.IsConnectedAsync(this.AccountInfo);
        this.IsSessionConnected = await this._sessionManager.IsConnectedAsync();
        this._timer.Enabled = this.IsConnected;
    }

    public bool IsConnected
    {
        get => GetPropertyValue<bool>(nameof(IsConnected));
        private set => SetPropertyValue(nameof(IsConnected), value);
    }

    public bool IsSessionConnected
    {
        get => GetPropertyValue<bool>(nameof(IsSessionConnected));
        private set => SetPropertyValue(nameof(IsSessionConnected), value);
    }


    public TimeSpan RemainingTime
    {
        get => GetPropertyValue<TimeSpan>(nameof(RemainingTime));
        private set => SetPropertyValue(nameof(RemainingTime), value);
    }

    public string GetFormattedRemainingTime()
    {
        return $"{(int) RemainingTime.TotalHours:D2}:{RemainingTime.Minutes:D2}:{RemainingTime.Seconds:D2}";
    }

    public void Dispose()
    {
        _sessionManager.StateChanged -= this.OnSessionManagerStateChanged;
        _timer.Enabled = false;
        _timer.Dispose();
    }

    public bool IsSwitchDisable()
    {
        return !IsConnected && IsSessionConnected;
    }

    public bool IsEditDisable()
    {
        return IsConnected;
    }

    public bool IsDeleteDisable()
    {
        return IsConnected;
    }

    public async Task EditAsync()
    {
        var accountInfo = AccountInfo.DeepClone();

        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(AddOrEditAccountDialog.AccountInfo), accountInfo }
                                   };

        var dialogReference = await DialogService.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await _accountManagement.UpdateAsync(accountInfo);
            AccountInfo = accountInfo;
        }
    }

    public IDialogService DialogService { get; set; }

    public IndexViewModel IndexViewModel { get; set; }

    public async Task DeleteAsync()
    {
        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(DeleteConfirmDialog.AccountInfo), AccountInfo }
                                   };

        var dialogReference = await DialogService.ShowAsync<DeleteConfirmDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await _accountManagement.RemoveAsync(AccountInfo);

            // TODO: Improve this later.
            await IndexViewModel.ReloadAsync();
        }
    }

    public async Task CheckedChangedAsync()
    {
        // TODO: Improve this later.
        await IndexViewModel.CheckedChangedAsync(this);
    }
}