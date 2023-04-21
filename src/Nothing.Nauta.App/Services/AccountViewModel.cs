namespace Nothing.Nauta.App.Services;

using System.Timers;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.App.ViewModels;

public class AccountViewModel : ViewModelBase, IDisposable
{
    private readonly ISessionManager _sessionManager;
    private readonly Timer _timer = new Timer(1000);

    public AccountInfo AccountInfo { get; }

    public AccountViewModel(AccountInfo accountInfo, ISessionManager sessionManager)
    {
        AccountInfo = accountInfo;
        _sessionManager = sessionManager;
        _timer.Elapsed += OnElapsed;
    }

    private void OnElapsed(object? sender, ElapsedEventArgs e)
    {
        Task.Run(
            async () =>
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
                });
    }

    public override async Task InitializeAsync()
    {
        IsConnected = await _sessionManager.IsConnectedAsync(AccountInfo);
        if (IsConnected)
        {
            _timer.Enabled = true;
        }
    }

    public bool IsConnected
    {
        get => GetPropertyValue<bool>(nameof(IsConnected));
        private set => SetPropertyValue(nameof(IsConnected), value);
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
        this._timer.Elapsed -= OnElapsed;
        if (this._timer.Enabled)
        {
            this._timer.Enabled = false;
        }

        this._timer.Dispose();
    }

    public bool IsSwitchDisable()
    {
        throw new NotImplementedException();
    }

    public bool IsEditDisable()
    {
        throw new NotImplementedException();
    }

    public bool IsDeleteDisable()
    {
        throw new NotImplementedException();
    }
}