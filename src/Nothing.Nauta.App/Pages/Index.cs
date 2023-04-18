namespace Nothing.Nauta.App.Pages
{
    using System.Text.Json;
    using System.Timers;

    using Force.DeepCloner;

    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;

    using MudBlazor;

    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Data.Extensions;
    using Nothing.Nauta.App.Dialogs;
    using Nothing.Nauta.App.Services;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.Interfaces;

    public partial class Index
    {
        private const string  NautaSessionData = "NautaSessionData";

        private readonly List<AccountViewModel> _accounts = new List<AccountViewModel>();

        private Timer _timer = new Timer(1000);
        
        private bool _isOverlayVisible;

        [Inject]
        public ISnackbar? Snackbar { get; set; }

        [Inject]
        public IAccountManagement? AccountManagement { get; set; }
        
        [Inject]
        public ISessionHandler? SessionHandler { get; set; }

        [Inject]
        public ISecureStorage? SecureStorage { get; set; }

        [Inject]
        public IDialogService? DialogService{ get; set; }

        private void OnElapsed(object? sender, ElapsedEventArgs e)
        {
            var accountViewModel = _accounts.FirstOrDefault(model => model.IsConnected);
            if (accountViewModel is null)
            {
                _timer.Enabled = false;
            }
            else
            {
                InvokeAsync(
                    async () =>
                        {
                            var sessionData = await GetSessionDataAsync();
                            accountViewModel.RemainingTime = await SessionHandler!.RemainingTimeAsync(sessionData);
                            StateHasChanged();
                        });
            }
        }

        protected Task BackgroundRunAsync(Func<Task> task, Func<Task>? onFinishTask = null)
        {
            _isOverlayVisible = true;

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
                            _isOverlayVisible = false;
                            _ = InvokeAsync(
                                async () =>
                                    {
                                        StateHasChanged();
                                        if (exception is not null)
                                        {
                                            Snackbar!.Add(exception.Message);
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

        protected override async Task OnInitializedAsync()
        {
            _timer.Elapsed += OnElapsed;
            await ReloadAsync();
        }

        private async Task ReloadAsync()
        {
            _timer.Enabled = false;

            var sessionData = await GetSessionDataAsync();
            
            string? currentSessionUserName = null;
            sessionData?.TryGetValue(SessionDataKeys.UserName, out currentSessionUserName);

            _accounts.Clear();
            foreach (var accountInfo in await AccountManagement!.ListAsync())
            {
                var isConnected = accountInfo.GetUserName() == currentSessionUserName;
                var accountViewModel = new AccountViewModel(accountInfo, isConnected);
                if (isConnected)
                {
                    _timer.Enabled = true;
                }

                _accounts.Add(accountViewModel);
            }

            StateHasChanged();
        }

        private async Task<Dictionary<string, string>?> GetSessionDataAsync()
        {
            Dictionary<string, string>? sessionData = null;
            try
            {
                var serializedSessionData = await SecureStorage!.GetAsync(NautaSessionData);
                sessionData = JsonSerializer.Deserialize<Dictionary<string, string>>(serializedSessionData);
            }
            catch (Exception)
            {
                // Ignore
            }

            return sessionData;
        }

        private async Task EditAsync(AccountViewModel context)
        {
            var accountInfo = context.AccountInfo.DeepClone();

            var dialogParameters = new DialogParameters
                                       {
                                           { nameof(AddOrEditAccountDialog.AccountInfo), accountInfo }
                                       };

            var dialogReference = await DialogService!.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                await AccountManagement!.UpdateAsync(accountInfo);
                await ReloadAsync();
            }
        }

        private async Task DeleteAsync(AccountViewModel context)
        {
            var dialogParameters = new DialogParameters
                                       {
                                           { nameof(DeleteCorfirmDialog.AccountInfo), context.AccountInfo }
                                       };

            var dialogReference = await DialogService!.ShowAsync<DeleteCorfirmDialog>(string.Empty, dialogParameters);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                await AccountManagement!.RemoveAsync(context.AccountInfo);
                await ReloadAsync();
            }
        }

        private async Task AddAccountAsync(MouseEventArgs arg)
        {
            var accountInfo = new AccountInfo();
            var dialogParameters = new DialogParameters
                                       {
                                           { nameof(DeleteCorfirmDialog.AccountInfo), accountInfo }
                                       };

            var dialogReference = await DialogService!.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                await AccountManagement!.AddAsync(accountInfo);
                await ReloadAsync();
            }
        }

        private async Task CheckedChangedAsync(AccountViewModel context)
        {
            if (!context.IsConnected)
            {
                await BackgroundRunAsync(() => OpenAsync(context), ReloadAsync);
            }
            else
            {
                await BackgroundRunAsync(CloseAsync, ReloadAsync);
            }
        }

        private async Task CloseAsync()
        {
            try
            {
                var sessionData = await GetSessionDataAsync();
                await SessionHandler!.CloseAsync(sessionData);
                SecureStorage!.Remove(NautaSessionData);
            }
            catch (Exception ex)
            {
                Snackbar!.Add(ex.Message, Severity.Error);
            }
        }

        private async Task OpenAsync(AccountViewModel context)
        {
            var sessionData = await SessionHandler!.OpenAsync(context.AccountInfo.GetUserName(), context.AccountInfo.Password);
            if (sessionData is not null)
            {
                await SecureStorage!.SetAsync(NautaSessionData, JsonSerializer.Serialize(sessionData));
            }
        }

        private bool IsDisable(AccountViewModel context)
        {
            return !context.IsConnected && _accounts.Any(model => model.IsConnected);
        }

        private async Task ManualResetAsync()
        {
            var dialogReference = await DialogService!.ShowAsync<ManualResetCorfirmDialog>(string.Empty);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                SecureStorage!.Remove(NautaSessionData);
                await ReloadAsync();
            }
        }

        private bool AnyAccount()
        {
            return _accounts is not null && _accounts.Count > 0;
        }
    }
}