using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    class Day07 : ASolution
    {
        public IEnumerable<Bag> Bags { get; }

        public Day07() : base(07, 2020, "")
        {
            Bags = Input.SplitByNewline().Select(b => new Bag(b));
        }

        protected override string SolvePartOne()
        {
            //29 wrong
            var bags = Bags.Where(b => b.Bags.Any(ib => ib.Quality == "shiny" && ib.Color == "gold")).ToList();
            var count = 0;
            do
            {
                var currentBags = Bags.Where(b => !bags.Any(ob => ob.Quality == b.Quality && ob.Color == b.Color) &&
                                                   b.Bags.Any(ib => bags.Any(ob => ob.Quality == ib.Quality && ob.Color == ib.Color)));

                count = currentBags.Count();
                bags.AddRange(currentBags);
            }
            while (count != 0);


            return bags.Count().ToString();
        }

        protected override string SolvePartTwo()
        {
            var startBag = Bags.FirstOrDefault(b => b.Quality == "shiny" && b.Color == "gold");
            var currentBags = startBag.Bags;
            var count = currentBags.Count();

            do
            {
                var bag = currentBags.First();
                var currentBag = Bags.FirstOrDefault(b => b.Quality == bag.Quality && b.Color == bag.Color);
                var bags = currentBag.Bags;
                count += bags.Count();
                currentBags.AddRange(bags);
                currentBags.Remove(bag);
            }
            while (currentBags.Any());
            return count.ToString();
        }
    }
}
