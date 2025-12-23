using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AdventOfCode.AdventOfCode.Solutions.Models;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class IdValidatorTests
    {
        private string Input = "11-22," +
                               "95-115," +
                               "998-1012," +
                               "1188511880-1188511890," +
                               "222220-222224," +
                               "1698522-1698528," +
                               "446443-446449," +
                               "38593856-38593862";
        private string InputAddon = ",565653-565659," +
                                    "824824821-824824827," +
                                    "2121212118-2121212124";

        [TestMethod]
        public void Test_DayTwoPartOneExample()
        {
            var ranges = Input.Split(",");
            var validator = new IdValidator();
            var invalidIds = validator.FindInvalidIds(ranges);
            var sum = invalidIds.Sum();
            Assert.AreEqual(1227775554, sum);
        }

        [TestMethod]
        public void Test_DayTwoPartTwoExample()
        {
            var ranges = (Input + InputAddon).Split(',');
            var validator = new IdValidator();
            var invalidIds = validator.FindInvalidIds(ranges, true);
            var sum = invalidIds.Sum();
            Assert.AreEqual(4174379265, sum);
        }
    }
}
