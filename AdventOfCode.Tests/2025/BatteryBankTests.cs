using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Solutions.Utils;
using AdventOfCode.AdventOfCode.Solutions.Models;
using System.Linq;
using AdventOfCode.AdventOfCode.Solutions.Models._2025;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class BatteryBankTests
    {
        private string Input = "987654321111111\n" +
                               "811111111111119\n" +
                               "234234234234278\n" +
                               "818181911112111";

        [TestMethod]
        public void Test_DayThreePartOneExample()
        {
            var inputs = Input.SplitByNewline();
            var banks = inputs.Select(x => new BatteryBank(x)).ToList();

            var totalJoltage = banks.Sum(x => x.MaximumJoltage);

            Assert.HasCount(4, banks);
            
            Assert.AreEqual(98, banks[0].MaximumJoltage);
            Assert.AreEqual(89, banks[1].MaximumJoltage);
            Assert.AreEqual(78, banks[2].MaximumJoltage);
            Assert.AreEqual(92, banks[3].MaximumJoltage);

            Assert.AreEqual(357, totalJoltage);
        }

        [TestMethod]
        public void Test_DayThreePartTwoExample()
        {
            var inputs = Input.SplitByNewline();

            var banks = inputs.Select(x => new BatteryBank(x, 12)).ToList();

            Assert.HasCount(4, banks);

            Assert.AreEqual(987654321111, banks[0].MaximumJoltage);
            Assert.AreEqual(811111111119, banks[1].MaximumJoltage);
            Assert.AreEqual(434234234278, banks[2].MaximumJoltage);
            Assert.AreEqual(888911112111, banks[3].MaximumJoltage);

            long totalJoltage = banks.Sum(x => x.MaximumJoltage);
            Assert.AreEqual(3121910778619, totalJoltage);
        }
    }
}
