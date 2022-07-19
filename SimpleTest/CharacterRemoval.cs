using TextABCSort.Interfaces;

namespace TextABCSort;

public class CharacterRemoval : ICharacterRemoval
{
    public string Remove(string input, char[] charsToRemove)
    {
        foreach (var chr in charsToRemove)
        {

            input = input.Replace(chr.ToString(), string.Empty);
        }
        

        return input;
    }
}