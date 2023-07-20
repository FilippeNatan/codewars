Console.WriteLine("Write seconds to get readable time:");
string? seconds = Console.ReadLine();
Console.WriteLine(TimeFormat.GetReadableTime(Convert.ToInt32(seconds)));

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = 0;
        int minutes = 0;

        if(seconds >= 3600)
        {
            hours = seconds/3600;
            seconds = seconds - (3600 * hours);
        }
        if(seconds >= 60)
        {
            minutes = seconds/60;
            seconds = seconds - (60 * minutes);
        }
        
        string? time = $"{hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}";
        return time;
    }
}