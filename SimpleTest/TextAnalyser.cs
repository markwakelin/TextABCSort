using TextABCSort.Interfaces;

namespace TextABCSort;

public class TextAnalyser : ITextAnalyser
{
    private readonly ILogger _logger;
    private readonly ICharacterRemoval _characterRemoval;
    private readonly IWordSort _wordSort;

    public TextAnalyser(ILogger logger, ICharacterRemoval characterRemoval,
        IWordSort wordSort)
    {
        _logger = logger;
        _characterRemoval = characterRemoval;
        _wordSort = wordSort;
    }
    public string AnalyseInput(string someInput)
    {
        _logger.Log("start CalculateTotal");

        someInput = _characterRemoval.Remove(someInput, ".,;'".ToCharArray());
        var sortedWords = _wordSort.Sort(someInput.Split(" ").ToList());


        _logger.Log("end CalculateTotal");

        return string.Join(" ", sortedWords);
    }
    
}