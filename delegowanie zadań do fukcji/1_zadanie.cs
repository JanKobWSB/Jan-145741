using System;

class Program
{
    static void Main()
    {
        int seconds = 2450;
        string formattedTime = FormatTime(seconds);
        Console.WriteLine(formattedTime); // Output: 00:05:32
    }

    static string FormatTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        string formattedHours = hours.ToString().PadLeft(2, '0');
        string formattedMinutes = minutes.ToString().PadLeft(2, '0');
        string formattedSeconds = remainingSeconds.ToString().PadLeft(2, '0');

        return $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
    }
}
