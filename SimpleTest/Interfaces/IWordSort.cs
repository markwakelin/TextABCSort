namespace TextABCSort.Interfaces;

public interface IWordSort
{
    IEnumerable<string> Sort(List<string> input);
}