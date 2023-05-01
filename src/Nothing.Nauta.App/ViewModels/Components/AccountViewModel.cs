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
using Nothing.Nauta.App.Data.Services.Interfaces;
using Nothing.Nauta.App.Dialogs;
using Nothing.Nauta.App.Services.EventArgs;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels;
using Nothing.Nauta.App.ViewModels.Pages;

/// <summary>
/// The account view model class.
/// </summary>
public class AccountViewModel : ViewModelBase, IDisposable
{
    private readonly ISessionManager sessionManager;
    private readonly IAccountRepository accountRepository;
    private readonly IDeviceDisplay deviceDisplay;
    private readonly Timer timer = new Timer(1000);

    private bool isInitialized;

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountViewModel"/> class.
    /// </summary>
    /// <param name="accountInfo">The account info.</param>
    /// <param name="sessionManager">The session manager.</param>
    /// <param name="accountRepository">The account repository.</param>
    /// <param name="deviceDisplay">The device display.</param>
    public AccountViewModel(AccountInfo accountInfo, ISessionManager sessionManager, IAccountRepository accountRepository, IDeviceDisplay deviceDisplay)
    {
        this.AccountInfo = accountInfo;

        this.sessionManager = sessionManager;
        this.sessionManager.StateChanged += this.OnSessionManagerStateChanged;
        this.accountRepository = accountRepository;

        this.deviceDisplay = deviceDisplay;
        this.deviceDisplay.MainDisplayInfoChanged += this.OnDeviceDisplayMainDisplayInfoChanged;
        this.DisplayOrientation = this.deviceDisplay.MainDisplayInfo.Orientation;

        this.timer.Elapsed += this.OnTimerElapsed;
        this.isInitialized = false;
    }

    /// <summary>
    /// Gets the account info.
    /// </summary>
    public AccountInfo AccountInfo
    {
        get => this.GetPropertyValue<AccountInfo>(nameof(this.AccountInfo));
        private set => this.SetPropertyValue(nameof(this.AccountInfo), value);
    }

    /// <summary>
    /// Gets a value indicating whether the account is connected.
    /// </summary>
    public bool IsConnected
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsConnected));
        private set => this.SetPropertyValue(nameof(this.IsConnected), value);
    }

    /// <summary>
    /// Gets a value indicating whether a session is connected.
    /// </summary>
    public bool IsSessionConnected
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsSessionConnected));
        private set => this.SetPropertyValue(nameof(this.IsSessionConnected), value);
    }

    /// <summary>
    /// Gets the remaining time.
    /// </summary>
    public TimeSpan RemainingTime
    {
        get => this.GetPropertyValue<TimeSpan>(nameof(this.RemainingTime));
        private set => this.SetPropertyValue(nameof(this.RemainingTime), value);
    }

    /// <summary>
    /// Gets the total time.
    /// </summary>
    public TimeSpan TotalTime
    {
        get => this.GetPropertyValue<TimeSpan>(nameof(this.TotalTime));
        private set => this.SetPropertyValue(nameof(this.TotalTime), value);
    }

    /// <summary>
    /// Gets the display orientation.
    /// </summary>
    public DisplayOrientation DisplayOrientation
    {
        get => this.GetPropertyValue<DisplayOrientation>(nameof(this.DisplayOrientation));
        private set => this.SetPropertyValue(nameof(this.DisplayOrientation), value);
    }

    /// <summary>
    /// Gets the formatted remaining time.
    /// </summary>
    public string FormattedRemainingTime => $"{(int)this.RemainingTime.TotalHours:D2}:{this.RemainingTime.Minutes:D2}:{this.RemainingTime.Seconds:D2}";

    /// <summary>
    /// Gets a value indicating whether the switch is disabled.
    /// </summary>
    public bool IsSwitchDisabled => !this.isInitialized || (!this.IsConnected && this.IsSessionConnected);

    /// <summary>
    /// Gets a value indicating whether the edit is disabled.
    /// </summary>
    public bool IsEditDisabled => !this.isInitialized || this.IsConnected;

    /// <summary>
    /// Gets a value indicating whether the delete is disabled.
    /// </summary>
    public bool IsDeleteDisable => !this.isInitialized || this.IsConnected;

    public IDialogService? DialogService { get; set; }

    public IndexViewModel? IndexViewModel { get; set; }

    /// <summary>
    /// Gets the remaining time percent.
    /// </summary>
    public double RemainingTimePercent
    {
        get
        {
            try
            {
                var remainingTimePercent = 100d * (this.RemainingTime.TotalHours / this.TotalTime.TotalHours);
                return double.IsNaN(remainingTimePercent) ? 0 : remainingTimePercent;
            }
            catch
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// Gets the remaining time progress bar color.
    /// </summary>
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

    /// <inheritdoc />
    public override async Task InitializeAsync()
    {
        try
        {
            var isConnected = await this.sessionManager.IsConnectedAsync();
            await this.UpdateConnectionStatusAsync(isConnected);
        }
        finally
        {
            this.isInitialized = true;
        }
    }

    /// <summary>
    /// Edits the account info.
    /// </summary>
    /// <returns>
    /// A <see cref="Task"/>.
    /// </returns>
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

    /// <summary>
    /// Deletes the account info.
    /// </summary>
    /// <returns>
    /// A <see cref="Task"/>.
    /// </returns>
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

    /// <summary>
    /// Toggles the connection status.
    /// </summary>
    /// <returns>
    /// A <see cref="Task"/>.
    /// </returns>
    public async Task ToggleConnectionStatusAsync()
    {
        // TODO: Improve this later.
        await this.IndexViewModel!.ToggleConnectionStatusAsync(this);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Disposes the object.
    /// </summary>
    /// <param name="disposing">
    /// Indicates whether the object is disposing.
    /// </param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            this.sessionManager.StateChanged -= this.OnSessionManagerStateChanged;
            this.deviceDisplay.MainDisplayInfoChanged -= this.OnDeviceDisplayMainDisplayInfoChanged;
            this.timer.Elapsed -= this.OnTimerElapsed;
            this.timer.Enabled = false;
            this.timer.Dispose();
        }
    }

    private void OnTimerElapsed(object? sender, ElapsedEventArgs e)
    {
        _ = Task.Run(
            async () =>
                {
                    if (!this.IsConnected)
                    {
                        this.timer.Enabled = false;
                    }
                    else
                    {
                        try
                        {
                            var (total, remainingTime) = await this.sessionManager.GetTimeAsync();
                            this.TotalTime = total;
                            this.RemainingTime = remainingTime;
                        }
                        catch
                        {
                            // Ignored
                        }
                    }
                });
    }

    private void OnDeviceDisplayMainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e)
    {
        this.DisplayOrientation = e.DisplayInfo.Orientation;
    }

    private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
    {
        this.InvokeAsync?.Invoke(async () => await this.UpdateConnectionStatusAsync(e.IsConnected));
    }

    private async Task UpdateConnectionStatusAsync(bool isConnected)
    {
        this.IsSessionConnected = isConnected;
        this.IsConnected = isConnected && await this.sessionManager.IsOpenAsync(this.AccountInfo);

        if (!this.IsConnected)
        {
            this.TotalTime = TimeSpan.Zero;
            this.RemainingTime = TimeSpan.Zero;
        }

        try
        {
            this.timer.Enabled = this.IsConnected;
        }
        catch (ObjectDisposedException)
        {
            // Ignore
        }
    }
}