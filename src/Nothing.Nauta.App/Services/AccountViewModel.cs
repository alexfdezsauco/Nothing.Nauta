namespace Nothing.Nauta.App.Services;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Extensions;

public class AccountViewModel
{
    private readonly Dictionary<string, string>? sessionData;

    private TimeSpan? remainingTime;

    public AccountInfo AccountInfo { get; }

    public AccountViewModel(AccountInfo accountInfo, Dictionary<string, string>? sessionData)
    {
        this.sessionData = sessionData;
        this.AccountInfo = accountInfo;
    }

    public bool IsConnected
    {
        get
        {
            if (this.sessionData?.TryGetValue(SessionDataKeys.UserName, out var currentSessionUserName) ?? false)
            {
                return this.AccountInfo.GetUserName() == currentSessionUserName;
            }

            return false;
        }
    }

    public TimeSpan RemainingTime
    {
        get
        {
            if (this.remainingTime is null)
            {
                return TimeSpan.Zero;
            }

            if (this.sessionData is null || !this.sessionData.TryGetValue(SessionDataKeys.Started, out var started) || !DateTime.TryParse(started, out var startDateTime))
            {
                return TimeSpan.Zero;
            }

            return this.remainingTime.Value.Subtract(DateTime.Now.Subtract(startDateTime));
        }

        set => this.remainingTime = value;
    }

    public string GetFormattedRemainingTime()
    {
        return $"{(int) this.RemainingTime.TotalHours:D2}:{this.RemainingTime.Minutes:D2}:{this.RemainingTime.Seconds:D2}";
    }
}