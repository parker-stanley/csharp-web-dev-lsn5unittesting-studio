using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {

        //1. balanced - test for a string entered with only brackets
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //2. balanced - test for a string entered with brackets at the beginning and end
        [TestMethod]
        public void OutsideBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        
        //3. balanced - test for a string entered with one bracket in the middle of the string
        [TestMethod]
        public void InsideBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        //4. balanced - tests for a string entered with no brackets
        [TestMethod]
        public void NoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        //5. balanced - test for an empty string
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //6. balanced - test for two instances of bracket pairs
        [TestMethod]
        public void MultipleBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch[Code]]"));
        }

        //7. unbalanced - test for single bracket at the beginning
        public void SingleBeginningBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        //8. unbalanced - test for single bracket at the end
        public void SingleEndingBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        //9. unbalanced - test for incorrectly paired brackets
        public void IncorrectBracketPari()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }

        //10. unbalanced - test for only two brackets of the same direction
        public void DuplicateBracketsWithNoMatches()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode["));
        }

        //11. unbalanced - test for when only one bracket is passed and nothing else
        public void OnlyOneBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        //12. unbalanced - test for when there are multiple prolems
        public void HotMess()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][Laun]chCode[["));
        }

    }
}
