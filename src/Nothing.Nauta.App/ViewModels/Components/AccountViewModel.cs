namespace Nothing.Nauta.App.ViewModels.Components;

using System.Timers;

using Force.DeepCloner;

using MudBlazor;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Dialogs;
using Nothing.Nauta.App.Services.EventArgs;
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
    }

    private void OnTimerElapsed(object? sender, ElapsedEventArgs e)
    {
        _ = Task.Run(
            async () =>
                {
                    IsConnected = await _sessionManager.IsConnectedAsync(AccountInfo);
                    if (!IsConnected)
                    {
                        _timer.Enabled = false;
                    }
                    else
                    {
                        var (total, remainingTime) = await _sessionManager.GetTimeAsync();
                        TotalTime = total;
                        RemainingTime = remainingTime;
                    }
                });
    }

    public override async Task InitializeAsync()
    {
        _timer.Elapsed += OnTimerElapsed;
        _sessionManager.StateChanged += OnSessionManagerStateChanged;
        await UpdateConnectionStatusAsync();
    }

    private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
    {
        InvokeAsync?.Invoke(async () => await UpdateConnectionStatusAsync());
    }

    private async Task UpdateConnectionStatusAsync()
    {
        IsConnected = await _sessionManager.IsConnectedAsync(AccountInfo);
        IsSessionConnected = await _sessionManager.IsConnectedAsync();

        try
        {
            _timer.Enabled = IsConnected;
        }
        catch (ObjectDisposedException)
        {
            // ignore:
        }
    }

    public AccountInfo AccountInfo
    {
        get => GetPropertyValue<AccountInfo>(nameof(AccountInfo));
        private set => SetPropertyValue(nameof(AccountInfo), value);
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

    public TimeSpan TotalTime
    {
        get => GetPropertyValue<TimeSpan>(nameof(TotalTime));
        private set => SetPropertyValue(nameof(TotalTime), value);
    }

    public string FormattedRemainingTime => $"{(int)RemainingTime.TotalHours:D2}:{RemainingTime.Minutes:D2}:{RemainingTime.Seconds:D2}";

    public bool IsSwitchDisable => !IsConnected && IsSessionConnected;

    public bool IsEditDisable => IsConnected;

    public bool IsDeleteDisable => IsConnected;

    public IDialogService? DialogService { get; set; }

    public IndexViewModel? IndexViewModel { get; set; }

    public void Dispose()
    {
        _sessionManager.StateChanged -= OnSessionManagerStateChanged;
        _timer.Elapsed -= OnTimerElapsed;
        _timer.Enabled = false;
        _timer.Dispose();
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

    public double RemainingTimePercent
    {
        get
        {
            var remainingTimePercent = 100d * (RemainingTime.TotalHours / TotalTime.TotalHours);
            return double.IsNaN(remainingTimePercent) ? 0 : remainingTimePercent;
        }
    }

    public Color RemainingTimeProgressBarColor
    {
        get
        {
            if (RemainingTime.TotalMinutes < 1)
            {
                return Color.Error;
            }

            if (RemainingTime.TotalMinutes < 5)
            {
                return Color.Warning;
            }

            return Color.Success;
        }
    }
}