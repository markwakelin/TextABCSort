using TextABCSort.Interfaces;

namespace TextABCSort;

public class WordSort : IWordSort
{
    public IEnumerable<string> Sort(List<string> input)
    {
        return input.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ThenBy(x => x, StringComparer.Ordinal).ToList();
    }
}