using AdventOfCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class GameCpuTests
    {
        const string _input = "nop +0\n" +
                              "acc +1\n" +
                              "jmp +4\n" +
                              "acc +3\n" +
                              "jmp -3\n" +
                              "acc -99\n" +
                              "acc +1\n" +
                              "jmp -4\n" +
                              "acc +6\n";

        GameCpu _cpu = new GameCpu(_input);

        [TestMethod]
        public void Test_DayEightPartOneExample()
        {
            try
            {
                _cpu.Execute();
                Assert.Fail();
            }
            catch (InfiniteLoopException)
            {
                Assert.AreEqual(5, _cpu.Accumulator);
            }
        }

        [TestMethod]
        public void Test_DayEightPartTwoExample()
        {
            _cpu.Repair();
            _cpu.Execute();
            Assert.AreEqual(8, _cpu.Accumulator);
        }
    }
}
