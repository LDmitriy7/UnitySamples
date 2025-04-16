using System;

public static class DateUtility
{
    public static DateTime ToDateTime(long timestamp)
    {
        var offset = DateTimeOffset.FromUnixTimeSeconds(timestamp);
        return offset.UtcDateTime;
    }

    public static long ToTimestamp(DateTime time)
    {
        var offset = new DateTimeOffset(time);
        return offset.ToUnixTimeSeconds();
    }
}
