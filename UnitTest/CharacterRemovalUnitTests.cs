using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextABCSort;

namespace UnitTest;

[TestClass]
public class CharacterRemovalUnitTests
{
    [TestMethod]
    public void Characters_Are_Removed_Correctly()
    {
        var target = new CharacterRemoval();
            
        var input = "The big, brown, fox";
        var charsToRemove = ".,;'".ToCharArray();
        var expected = "The big brown fox";

        Assert.AreEqual(expected, target.Remove(input, charsToRemove));
    }
}