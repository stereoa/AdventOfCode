using AdventOfCode.Solutions;
using AdventOfCode.Solutions.Year2020;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class BagTests
    {
        const string _input = "light red bags contain 1 bright white bag, 2 muted yellow bags.\n" +
                              "dark orange bags contain 3 bright white bags, 4 muted yellow bags.\n" +
                              "bright white bags contain 1 shiny gold bag.\n" +
                              "muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.\n" +
                              "shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.\n" +
                              "dark olive bags contain 3 faded blue bags, 4 dotted black bags.\n" +
                              "vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.\n" +
                              "faded blue bags contain no other bags.\n" +
                              "dotted black bags contain no other bags.";

        const string _inputTwo = "shiny gold bags contain 2 dark red bags.\n" +
                                 "dark red bags contain 2 dark orange bags.\n" +
                                 "dark orange bags contain 2 dark yellow bags.\n" +
                                 "dark yellow bags contain 2 dark green bags.\n" +
                                 "dark green bags contain 2 dark blue bags.\n" +
                                 "dark blue bags contain 2 dark violet bags.\n" +
                                 "dark violet bags contain no other bags.";

        IEnumerable<Bag> _bags { get; set; }

        [TestMethod]
        public void Test_DaySevenPartOneExample()
        {
            _bags = _input.SplitByNewline().Select(b => new Bag(b));
            var bags = _bags.Where(b => b.Bags.Any(ib => ib.Quality == "shiny" && ib.Color == "gold")).ToList();
            var count = 0;
            do
            {
                var currentBags = _bags.Where(b => !bags.Any(ob => ob.Quality == b.Quality && ob.Color == b.Color) &&
                                                   b.Bags.Any(ib => bags.Any(ob => ob.Quality == ib.Quality && ob.Color == ib.Color)));

                count = currentBags.Count();
                bags.AddRange(currentBags);
            }
            while (count != 0);

            Assert.AreEqual(4, bags.Count());
        }

        [TestMethod]
        public void Test_DaySevenPartTwoExample()
        {
            _bags = _inputTwo.SplitByNewline().Select(b => new Bag(b));
            var startBag = _bags.SingleOrDefault(b => b.Quality == "shiny" && b.Color == "gold");
            var currentBags = startBag.Bags;
            var count = currentBags.Count();

            do
            {
                var bag = currentBags.First();
                var currentBag = _bags.SingleOrDefault(b => b.Quality == bag.Quality && b.Color == bag.Color);
                var bags = currentBag.Bags;
                count += bags.Count();
                currentBags.AddRange(bags);
                currentBags.Remove(bag);
            }
            while (currentBags.Any());

            Assert.AreEqual(126, count);
        }
    }
}
