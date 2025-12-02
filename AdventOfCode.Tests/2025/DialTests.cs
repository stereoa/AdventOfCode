using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Models;
using System.Linq;
using AdventOfCode.Solutions;
using AdventOfCode.Solutions.Utils;
using AdventOfCode.AdventOfCode.Solutions.Models;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class DialTests
    {
        private string Input = "L68\n" +
                               "L30\n" +
                               "R48\n" +
                               "L5 \n" +
                               "R60\n" +
                               "L55\n" +
                               "L1 \n" +
                               "L99\n" +
                               "R14\n" +
                               "L82\n";

        [TestMethod]
        public void Test_DayOnePartOneExample()
        {
            var directions = Input.SplitByNewline();
            var dial = new Dial();
            dial.ProcessDirections(directions);
            Assert.AreEqual(3, dial.ZeroStopCount);
        }

        [TestMethod]
        public void Test_DayOnePartTwoExample()
        { 
            var directions = Input.SplitByNewline();
            var dial = new Dial();
            dial.ProcessDirections(directions);
            Assert.AreEqual(3, dial.ZeroStopCount);
            Assert.AreEqual(3, dial.ZeroPassCount);
            Assert.AreEqual(6, dial.ZeroTotalCount);
        }
    }
}
