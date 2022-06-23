using BuderDinner.Application.Common.Interfaces.Services;

namespace BuderDinner.Infrastructure.Services;

public class DatetimeProvider : IDatetimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}