using TextABCSort.Interfaces;

namespace TextABCSort
{
    public class TextAbcSort : ITextABCSort
    {
        private readonly ITextAnalyser _textAnalyser;

        public TextAbcSort(ITextAnalyser textAnalyser)
        {
            _textAnalyser = textAnalyser;
        }
        public string CalculateTotal(string someInput)
        {
            if (someInput == null)
            {
                throw new DataMisalignedException("data not correct");
            }

            return _textAnalyser.AnalyseInput(someInput);
        }


    }
}
