using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextABCSort;

namespace UnitTest
{
    [TestClass]
    public class WordSortUnitTests
    {
        [TestMethod]
        public void Words_Are_Sorted_Correctly()
        {
            var target = new WordSort();
            

            var input = new List<string>
            {
                "Zoom",
                "Boom"
            };
          
            var expected = new List<string>
            {
                "Boom",
                "Zoom"
            };

            CollectionAssert.AreEqual(expected, target.Sort(input).ToList());
        }
    }
}