using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Models;
using System.Linq;
using AdventOfCode.Solutions;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class SonarSweeperTests
    {

        [TestMethod]
        public void Test_DayOnePartOneExample()
        {
            var input = "199\n" +
                        "200\n" +
                        "208\n" +
                        "210\n" +
                        "200\n" +
                        "207\n" +
                        "240\n" +
                        "269\n" +
                        "260\n" +
                        "263";
            var sweeper = new SonarSweep(input.ToIntArray("\n").ToList());
            Assert.AreEqual(10, sweeper.Measurements.Count());
            Assert.AreEqual(7, sweeper.GetIncreaseCount(sweeper.Measurements));
        }

        [TestMethod]
        public void Test_DayOnePartTwoExample()
        {
            var input = "199\n" +
                        "200\n" +
                        "208\n" +
                        "210\n" +
                        "200\n" +
                        "207\n" +
                        "240\n" +
                        "269\n" +
                        "260\n" +
                        "263";
            var sweeper = new SonarSweep(input.ToIntArray("\n").ToList());
            Assert.AreEqual(8, sweeper.Windows.Count());
            Assert.AreEqual(5, sweeper.GetIncreaseCount(sweeper.Windows));
        }
    }
}
