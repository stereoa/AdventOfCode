using AdventOfCode.Models;
using AdventOfCode.Solutions.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class SubmarineTests
    {

        [TestMethod]
        public void Test_DayTwoPartOneExample()
        {
            var input = "forward 5\n" +
                        "down 5\n" +
                        "forward 8\n" +
                        "up 3\n" +
                        "down 8\n" +
                        "forward 2";
            var submarine = new Submarine();

            var instructions = input.SplitByNewline().Select(i=>new SubmarineInstruction(i));

            submarine.Pilot(instructions);
            Assert.AreEqual(15, submarine.X);
            Assert.AreEqual(10, submarine.Y);
        }

        [TestMethod]
        public void Test_DayTwoPartTwoExample()
        {
            var input = "forward 5\n" +
                        "down 5\n" +
                        "forward 8\n" +
                        "up 3\n" +
                        "down 8\n" +
                        "forward 2";
            var submarine = new Submarine();

            var instructions = input.SplitByNewline().Select(i => new SubmarineInstruction(i));

            submarine.Pilot(instructions, true);
            Assert.AreEqual(15, submarine.X);
            Assert.AreEqual(60, submarine.Y);
            Assert.AreEqual(900, submarine.X * submarine.Y);
            Assert.AreEqual(10, submarine.Aim);
        }

    }
}
