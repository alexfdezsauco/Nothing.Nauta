using Nothing.Nauta.App.Services.Interfaces;

namespace Nothing.Nauta.App.Services;

public class TimeService : ITimeService
{
    public DateTime Now()
    {
        return DateTime.Now;
    }
}