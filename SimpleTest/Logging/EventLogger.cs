using TextABCSort.Interfaces;

namespace TextABCSort.Logging;

public class EventLogger : ILogger
{
    public void Log(string stuff)
    {
        Console.WriteLine(stuff);
    }
}