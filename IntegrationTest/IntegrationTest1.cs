using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextABCSort;
using TextABCSort.Logging;

namespace IntegrationTest
{
    [TestClass]
    public class IntegrationTest1
    {

        [TestMethod]
        public void WordSort()
        {
            var target = new TextAbcSort(new TextAnalyser(new ConsoleLogger(), new CharacterRemoval(), new WordSort()));

            Assert.AreEqual("Boom Zoom", target.CalculateTotal("Zoom Boom"));
        }

        [TestMethod]
        public void CaseSort()
        {
            var target = new TextAbcSort(new TextAnalyser(new ConsoleLogger(), new CharacterRemoval(), new WordSort()));

            Assert.AreEqual("Boom boom", target.CalculateTotal("boom Boom"));
        }

        [TestMethod]
        public void RemoveInvalidChars()
        {
            var target = new TextAbcSort(new TextAnalyser(new ConsoleLogger(), new CharacterRemoval(), new WordSort()));

            Assert.AreEqual("b b", target.CalculateTotal("b, b"));
        }

        [TestMethod]
        public void SimpleTest1()
        {
            var target = new TextAbcSort(new TextAnalyser(new ConsoleLogger(), new CharacterRemoval(), new WordSort()));

            Assert.AreEqual("baby Go go", target.CalculateTotal("Go baby, go"));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            var target = new TextAbcSort(new TextAnalyser(new ConsoleLogger(), new CharacterRemoval(), new WordSort()));

            Assert.AreEqual("ABC aBc abc CBA CBA cba", target.CalculateTotal("CBA, abc aBc ABC cba CBA."));
        }
    }
}