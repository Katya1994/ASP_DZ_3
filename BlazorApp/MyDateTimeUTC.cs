namespace BlazorApp;

public class MyDateTimeUTC: IMyDateTime
{
    public DateTime GetCurrentDate()
    {
        return DateTime.UtcNow;
    }
}