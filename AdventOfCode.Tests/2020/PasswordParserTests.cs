using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Models;
using System.Linq;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class PasswordParserTests
    {
        private ExpenseReport Report { get; set; }

        [TestMethod]
        public void Test_DayTwoPartOneExample()
        {
            var input = "1-3 a: abcde\n" +
                        "1-3 b: cdefg\n" +
                        "2-9 c: ccccccccc\n";
            var passwords = PasswordParser.Parse(input).ToList();
            Assert.AreEqual(3, passwords.Count());
            Assert.IsTrue(passwords[0].IsValidCharCount);
            Assert.IsFalse(passwords[1].IsValidCharCount);
            Assert.IsTrue(passwords[2].IsValidCharCount);
            Assert.AreEqual(2, passwords.Count(p => p.IsValidCharCount));
        }
    }
}
