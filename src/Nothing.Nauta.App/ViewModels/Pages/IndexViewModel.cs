// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndexViewModel.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.ViewModels.Pages;

using MudBlazor;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Extensions;
using Nothing.Nauta.App.Dialogs;
using Nothing.Nauta.App.Services.EventArgs;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels;
using Nothing.Nauta.App.ViewModels.Components;

public class IndexViewModel : ViewModelBase
{
    private readonly IAccountRepository accountRepository;
    private readonly ISessionManager sessionManager;
    private readonly IViewModelFactory viewModelFactory;
    private readonly IDeviceDisplay deviceDisplay;

    public IndexViewModel(IAccountRepository accountRepository, ISessionManager sessionManager, IViewModelFactory viewModelFactory, IDeviceDisplay deviceDisplay)
    {
        this.accountRepository = accountRepository;
        this.sessionManager = sessionManager;
        this.viewModelFactory = viewModelFactory;
        this.deviceDisplay = deviceDisplay;
    }

    public List<AccountViewModel>? Accounts
    {
        get => this.GetPropertyValue<List<AccountViewModel>>(nameof(this.Accounts));
        private set => this.SetPropertyValue(nameof(this.Accounts), value);
    }

    public bool IsSessionConnected
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsSessionConnected));
        private set => this.SetPropertyValue(nameof(this.IsSessionConnected), value);
    }

    public override async Task InitializeAsync()
    {
        this.deviceDisplay.MainDisplayInfoChanged += this.OnDeviceDisplayMainDisplayInfoChanged;
        this.DisplayOrientation = this.deviceDisplay.MainDisplayInfo.Orientation;

        this.sessionManager.StateChanged += this.OnSessionManagerStateChanged;
        this.IsSessionConnected = await this.sessionManager.IsConnectedAsync();

        await this.ReloadAsync();
    }

    public async Task ReloadAsync()
    {
        this.IsReloading = true;

        try
        {
            // TODO: Improves this later, observable collections?
            var accountViewModels = this.Accounts;
            if (accountViewModels is not null)
            {
                foreach (var accountViewModel in accountViewModels)
                {
                    accountViewModel.Dispose();
                }
            }

            var accounts = new List<AccountViewModel>();
            foreach (var accountInfo in await this.accountRepository.ListAsync())
            {
                var accountViewModel = await this.viewModelFactory.CreateAsync<AccountViewModel>(accountInfo);
                accounts.Add(accountViewModel);
            }

            this.Accounts = accounts;
        }
        finally
        {
            this.IsReloading = false;
        }
    }

    private void OnDeviceDisplayMainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e)
    {
        this.DisplayOrientation = e.DisplayInfo.Orientation;
    }

    private void OnSessionManagerStateChanged(object? sender, SessionManagerStateChangeEventArg e)
    {
        this.IsSessionConnected = e.IsConnected;
    }

    public bool IsReloading
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsReloading));
        private set => this.SetPropertyValue(nameof(this.IsReloading), value);
    }

    public bool IsOverlayVisible
    {
        get => this.GetPropertyValue<bool>(nameof(this.IsOverlayVisible));
        private set => this.SetPropertyValue(nameof(this.IsOverlayVisible), value);
    }

    public DisplayOrientation DisplayOrientation
    {
        get => this.GetPropertyValue<DisplayOrientation>(nameof(this.DisplayOrientation));
        private set => this.SetPropertyValue(nameof(this.DisplayOrientation), value);
    }

    public ISnackbar? Snackbar { get; set; }

    public IDialogService? DialogService { get; set; }

    public async Task AddAccountAsync()
    {
        var accountInfo = new AccountInfo();
        var dialogParameters = new DialogParameters
                                   {
                                       { nameof(DeleteConfirmDialog.AccountInfo), accountInfo },
                                   };

        var dialogReference = await this.DialogService!.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await this.accountRepository.AddAsync(accountInfo);
            await this.ReloadAsync();
        }
    }

    public async Task CheckedChangedAsync(AccountViewModel context)
    {
        if (!context.IsConnected)
        {
            await this.BackgroundRunAsync(() => this.OpenAsync(context));
        }
        else
        {
            await this.BackgroundRunAsync(this.CloseAsync, onErrorTask: this.ForceConnectionCloseAsync);
        }
    }

    protected Task BackgroundRunAsync(Func<Task> task, Func<Task>? onFinishTask = null, Func<Task>? onErrorTask = null)
    {
        this.IsOverlayVisible = true;

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
                        this.IsOverlayVisible = false;

                        _ = this.InvokeAsync?.Invoke(
                            async () =>
                                {
                                    if (exception is not null)
                                    {
                                        this.Snackbar?.Add(exception.Message, Severity.Error);
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

    private async Task CloseAsync()
    {
        await this.sessionManager.CloseAsync();
    }

    private async Task OpenAsync(AccountViewModel context)
    {
        await this.sessionManager.OpenAsync(context.AccountInfo.GetUserName(), context.AccountInfo.Password);
    }

    private async Task ForceConnectionCloseAsync()
    {
        var dialogReference = await this.DialogService!.ShowAsync<ForceConnectionCloseConfirmDialog>(string.Empty);
        if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
        {
            await this.sessionManager.ForceCloseAsync();
            await this.ReloadAsync();
        }
    }
}