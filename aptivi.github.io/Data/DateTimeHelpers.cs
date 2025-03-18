using System;
using System.Globalization;

namespace aptivi.github.io.Data
{
    public static class DateTimeHelpers
    {
        public static DateTimeOffset GetDateTimeFrom(string date)
        {
            if (DateTimeOffset.TryParseExact(date, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime))
                return dateTime;
            if (DateTimeOffset.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var justDate))
                return justDate;
            throw new Exception($"Can't parse date/time representation {date}");
        }
    }
}
