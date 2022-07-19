using TextABCSort.Interfaces;

namespace TextABCSort.Logging;

public class ConsoleLogger : ILogger
{
    public void Log(string stuff)
    {
        Console.WriteLine(stuff);
    }
}