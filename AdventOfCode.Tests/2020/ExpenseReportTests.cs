using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Models;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class ExpenseReportTests
    {
        private ExpenseReport Report { get; set; }

        [TestMethod]
        public void Test_DayOnePartOneExample()
        {
            var expenses = new int[] { 1721, 979, 366, 299, 675, 1456 };
            Report = new ExpenseReport(expenses, 2020);
            Assert.AreEqual("514579", Report.FindPair());
        }
    }
}
