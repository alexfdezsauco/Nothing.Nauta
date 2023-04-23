// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountViewModel.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
    private readonly ISessionManager sessionManager;
    private readonly IAccountRepository accountRepository;
    private readonly IDeviceDisplay deviceDisplay;
    private readonly Timer timer = new Timer(1000);

    public AccountViewModel(AccountInfo accountInfo, ISessionManager sessionManager, IAccountRepository accountRepository, IDeviceDisplay deviceDisplay)
    {
        this.AccountInfo = accountInfo;
        this.sessionManager = sessionManager;
        this.accountRepository = accountRepository;
        this.deviceDisplay = deviceDisplay;
    }

    public AccountInfo AccountInfo
    {
        get => this.GetPropertyValue<AccountInfo>(nameof(this.AccountInfo));
        private set => this.SetPropertyValue(nameof(this.AccountInfo), value);
    }

    public bool IsConnected
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsConnected));
        private set => this.SetPropertyValue(nameof(this.IsConnected), value);
    }

    public override async Task InitializeAsync()
    {
        this.deviceDisplay.MainDisplayInfoChanged += this.OnDeviceDisplayMainDisplayInfoChanged;
        this.DisplayOrientation = this.deviceDisplay.MainDisplayInfo.Orientation;

        this.timer.Elapsed += this.OnTimerElapsed;
        this.sessionManager.StateChanged += this.OnSessionManagerStateChanged;
        await this.UpdateConnectionStatusAsync();
    }

    private void OnTimerElapsed(object? sender, ElapsedEventArgs e)
    {
        _ = Task.Run(
            async () =>
                {
                    this.IsConnected = await this.sessionManager.IsConnectedAsync(this.AccountInfo);
                    if (!this.IsConnected)
                    {
                        this.timer.Enabled = false;
                    }
                    else
                    {
                        var (total, remainingTime) = await this.sessionManager.GetTimeAsync();
                        this.TotalTime = total;
                        this.RemainingTime = remainingTime;
                    }
                });
    }

    private void OnDeviceDisplayMainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e)
    {
        this.DisplayOrientation = e.DisplayInfo.Orientation;
    }

    private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
    {
        this.InvokeAsync?.Invoke(async () => await this.UpdateConnectionStatusAsync());
    }

    private async Task UpdateConnectionStatusAsync()
    {
        this.IsConnected = await this.sessionManager.IsConnectedAsync(this.AccountInfo);
        this.IsSessionConnected = await this.sessionManager.IsConnectedAsync();

        try
        {
            this.timer.Enabled = this.IsConnected;
        }
        catch (ObjectDisposedException)
        {
            // ignore:
        }
    }

    public bool IsSessionConnected
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsSessionConnected));
        private set => this.SetPropertyValue(nameof(this.IsSessionConnected), value);
    }

    public TimeSpan RemainingTime
    {
        get => this.GetPropertyValue<TimeSpan>(nameof(this.RemainingTime));
        private set => this.SetPropertyValue(nameof(this.RemainingTime), value);
    }

    public TimeSpan TotalTime
    {
        get => this.GetPropertyValue<TimeSpan>(nameof(this.TotalTime));
        private set => this.SetPropertyValue(nameof(this.TotalTime), value);
    }

    public DisplayOrientation DisplayOrientation
    {
        get => this.GetPropertyValue<DisplayOrientation>(nameof(this.DisplayOrientation));
        private set => this.SetPropertyValue(nameof(this.DisplayOrientation), value);
    }

    public string FormattedRemainingTime => $"{(int)this.RemainingTime.TotalHours:D2}:{this.RemainingTime.Minutes:D2}:{this.RemainingTime.Seconds:D2}";

    public bool IsSwitchDisable => !this.IsConnected && this.IsSessionConnected;

    public bool IsEditDisable => this.IsConnected;

    public bool IsDeleteDisable => this.IsConnected;

    public IDialogService? DialogService { get; set; }

    public IndexViewModel? IndexViewModel { get; set; }

    public double RemainingTimePercent
    {
        get
        {
            var remainingTimePercent = 100d * (this.RemainingTime.TotalHours / this.TotalTime.TotalHours);
            return double.IsNaN(remainingTimePercent) ? 0 : remainingTimePercent;
        }
    }

    public Color RemainingTimeProgressBarColor
    {
        get
        {
            if (this.RemainingTime.TotalMinutes < 1)
            {
                return Color.Error;
            }

            if (this.RemainingTime.TotalMinutes < 5)
            {
                return Color.Warning;
            }

            return Color.Success;
        }
    }

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async Task EditAsync()
    {
        var accountInfo = this.AccountInfo.DeepClone();

        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(AddOrEditAccountDialog.AccountInfo), accountInfo },
                                   };

        var dialogReference = await this.DialogService!.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await this.accountRepository.UpdateAsync(accountInfo);
            this.AccountInfo = accountInfo;
        }
    }

    public async Task DeleteAsync()
    {
        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(DeleteConfirmDialog.AccountInfo), this.AccountInfo },
                                   };

        var dialogReference = await this.DialogService!.ShowAsync<DeleteConfirmDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await this.accountRepository.RemoveAsync(this.AccountInfo);

            // TODO: Improve this later.
            await this.IndexViewModel!.ReloadAsync();
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            this.sessionManager.StateChanged -= this.OnSessionManagerStateChanged;
            this.timer.Elapsed -= this.OnTimerElapsed;
            this.timer.Enabled = false;
            this.timer.Dispose();
        }
    }

    public async Task CheckedChangedAsync()
    {
        // TODO: Improve this later.
        await this.IndexViewModel!.CheckedChangedAsync(this);
    }
}