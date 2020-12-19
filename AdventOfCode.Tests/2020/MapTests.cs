using AdventOfCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void Test_DayThreePartOneExample()
        {
            var input = "..##.......\n" +
                        "#...#...#..\n" +
                        ".#....#..#.\n" +
                        "..#.#...#.#\n" +
                        ".#...##..#.\n" +
                        "..#.##.....\n" +
                        ".#.#.#....#\n" +
                        ".#........#\n" +
                        "#.##...#...\n" +
                        "#...##....#\n" +
                        ".#..#...#.#\n";

            var map = new Map(input);

            var slope = new Slope(3, 1);

            uint expectedCollisions = 7;

            Assert.AreEqual(11, map.Height);
            Assert.AreEqual(11, map.Width);
            Assert.AreEqual(expectedCollisions, map.CalculateSlopeCollisions(slope));
        }
    }
}
