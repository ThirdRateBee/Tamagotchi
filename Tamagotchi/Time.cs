using System.Diagnostics;

public static class GameTime
{
    private static Stopwatch Time = Stopwatch.StartNew();

    public static double TotalSeconds => Time.Elapsed.TotalSeconds;
}