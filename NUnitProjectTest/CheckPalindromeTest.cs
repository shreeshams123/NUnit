using System;
using NUnit.Framework;
using NunitProject;
namespace NUnitProjectTest
{
    [TestFixture]   
    public class CheckPalindromeTest
    {
        private CheckPalindrome _checkPalindrome;
        [SetUp]
        public void Setup()
        {
            _checkPalindrome = new CheckPalindrome();
        }
        [Test]
        public void WhenGivenPalindrome_ThenReturnTrue()
        {
            string str = "madam";
            bool expected = true;
            bool actual=_checkPalindrome.IsPalindrome(str);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase("Alex",false)]
        public void WhenGivenNonPalindrome_ThenReturnFalse(string str,bool expected)
        {
            bool actual= _checkPalindrome.IsPalindrome(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
