using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad2;

namespace Zad2Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsStringValid_WhenIsValid_ShouldReturnTrue()
        {
            StringChecker stringChecker = new StringChecker();
            string[] testChar = new string[] { "(((()()))())", "(((()()))()))", ")((((()))()))", "()()()()()()()()", "((((((((()))))))(", "((()))()(())", "())(()" };
            stringChecker.StringToCheck = testChar[0];
            Assert.AreEqual(true, stringChecker.IsStringValid());

            stringChecker.StringToCheck = testChar[1];
            Assert.AreEqual(false, stringChecker.IsStringValid());

            stringChecker.StringToCheck = testChar[2];
            Assert.AreEqual(false, stringChecker.IsStringValid());

            stringChecker.StringToCheck = testChar[3];
            Assert.AreEqual(true, stringChecker.IsStringValid());

            stringChecker.StringToCheck = testChar[4];
            Assert.AreEqual(false, stringChecker.IsStringValid());

            stringChecker.StringToCheck = testChar[5];
            Assert.AreEqual(true, stringChecker.IsStringValid());

            stringChecker.StringToCheck = testChar[6];
            Assert.AreEqual(false, stringChecker.IsStringValid());
        }
    }
}
