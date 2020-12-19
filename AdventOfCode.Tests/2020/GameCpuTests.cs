using AdventOfCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch (InfiniteLoopException ex)
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
