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

        private List<AccountViewModel> _accounts;

        private Timer _timer = new Timer(1000);

        [Inject]
        public ISnackbar? Snackbar { get; set; }

        [Inject]
        public IAccountManagement? AccountManagement { get; set; }
        
        [Inject]
        public ISessionHandler? SessionHandler { get; set; }

        [Inject]
        public ISecureStorage SecureStorage { get; set; }

        [Inject]
        public IDialogService? DialogService{ get; set; }

        private void OnElapsed(object? sender, ElapsedEventArgs e)
        {
            var accountViewModel = this._accounts.FirstOrDefault(model => model.IsConnected);
            if (accountViewModel is null)
            {
                this._timer.Enabled = false;
            }
            else
            {
                InvokeAsync(
                    async () =>
                        {
                            var sessionData = await this.GetSessionDataAsync();
                            accountViewModel.RemainingTime = await this.SessionHandler!.RemainingTimeAsync(sessionData);
                            this.StateHasChanged();
                        });
            }
        }

        protected override async Task OnInitializedAsync()
        {
            _timer.Elapsed += OnElapsed;
            await this.ReloadAsync();
        }

        private async Task ReloadAsync()
        {
            var sessionData = await this.GetSessionDataAsync();

            string? userName = null;
            sessionData?.TryGetValue(SessionDataKeys.UserName, out userName);

            var accounts = new List<AccountViewModel>();
            foreach (var accountInfo in await this.AccountManagement!.ListAsync())
            {
                var isConnected = accountInfo.GetUserName() == userName;
                var accountViewModel = new AccountViewModel(accountInfo, isConnected);
                if (isConnected)
                {
                    this._timer.Enabled = true;
                }

                accounts.Add(accountViewModel);
            }

            this._accounts = accounts;
            this.StateHasChanged();
        }

        private async Task<Dictionary<string, string>?> GetSessionDataAsync()
        {
            Dictionary<string, string>? sessionData = null;
            try
            {
                var serializedSessionData = await this.SecureStorage.GetAsync(NautaSessionData);
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

            var dialogReference = await this.DialogService!.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                await this.AccountManagement!.UpdateAsync(accountInfo);
                await this.ReloadAsync();
            }
        }

        private async Task DeleteAsync(AccountViewModel context)
        {
            var dialogParameters = new DialogParameters
                                       {
                                           { nameof(DeleteCorfirmDialog.AccountInfo), context.AccountInfo }
                                       };

            var dialogReference = await this.DialogService!.ShowAsync<DeleteCorfirmDialog>(string.Empty, dialogParameters);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                await this.AccountManagement!.RemoveAsync(context.AccountInfo);
                await this.ReloadAsync();
            }
        }

        private async Task AddAccountAsync(MouseEventArgs arg)
        {
            var accountInfo = new AccountInfo();
            var dialogParameters = new DialogParameters
                                       {
                                           { nameof(DeleteCorfirmDialog.AccountInfo), accountInfo }
                                       };

            var dialogReference = await this.DialogService!.ShowAsync<AddOrEditAccountDialog>(string.Empty, dialogParameters);
            if (await dialogReference.GetReturnValueIfNotCancelledAsync<bool>())
            {
                await this.AccountManagement!.AddAsync(accountInfo);
                await this.ReloadAsync();
            }
        }

        private async Task CheckedChangedAsync(AccountViewModel context)
        {
            if (!context.IsConnected)
            {
                await this.OpenAsync(context);
            }
            else
            {
                await this.CloseAsync();
            }

            await this.ReloadAsync();
        }

        private async Task CloseAsync()
        {
            try
            {
                var sessionData = await this.GetSessionDataAsync();
                await this.SessionHandler!.CloseAsync(sessionData);
                this.SecureStorage.Remove(NautaSessionData);
            }
            catch (Exception ex)
            {
                this.Snackbar!.Add(ex.Message, Severity.Error);
            }
        }

        private async Task OpenAsync(AccountViewModel context)
        {
            Dictionary<string, string>? sessionData = null;
            try
            {
                sessionData = await this.SessionHandler!.OpenAsync(context.AccountInfo.GetUserName(), context.AccountInfo.Password);
            }
            catch (Exception ex)
            {
                this.Snackbar!.Add(ex.Message, Severity.Error);
            }

            if (sessionData is not null)
            {
                await this.SecureStorage.SetAsync(NautaSessionData, JsonSerializer.Serialize(sessionData));
            }
        }

        private bool IsDisable(AccountViewModel context)
        {
            return !context.IsConnected && this._accounts.Any(model => model.IsConnected);
        }

        private async Task ClearAsync()
        {
            this.SecureStorage.Remove(NautaSessionData);
            await this.ReloadAsync();
        }
    }
}