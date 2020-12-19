using AdventOfCode.Solutions.Year2020;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class CustomsDeclarationTests
    {
        const string _input = "abc\n" +
                              "\n" +
                              "a\n" +
                              "b\n" +
                              "c\n" +
                              "\n" +
                              "ab\n" +
                              "ac\n" +
                              "\n" +
                              "a\n" +
                              "a\n" +
                              "a\n" +
                              "a\n" +
                              "\n" +
                              "b";

        private IEnumerable<SurveyGroup> _groups = _input.Split("\n\n").Select(g => new SurveyGroup(g));

        [TestMethod]
        public void Test_DaySixPartOneExample()
        {
            var sum = _groups.Sum(g => g.DistinctTotal);
            Assert.AreEqual(11, sum);
        }

        [TestMethod]
        public void Test_DaySixPartTwoExample()
        {
            var sum = _groups.Sum(g => g.ElectedByAll.Count());
            Assert.AreEqual(6, sum);
        }
    }
}
