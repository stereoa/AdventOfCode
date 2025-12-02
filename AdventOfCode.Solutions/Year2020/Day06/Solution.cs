using AdventOfCode.Solutions;
using AdventOfCode.Solutions.Year2020;

namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day06
{

    class Day06 : SolutionBase
    {
        public IEnumerable<SurveyGroup> Groups { get; }

        public Day06() : base(06, 2020, "")
        {
            Groups = Input.Split("\n\n").Select(g => new SurveyGroup(g));
        }


        protected override string SolvePartOne()
        {
            return Groups.Sum(g => g.DistinctTotal).ToString();
        }

        protected override string SolvePartTwo()
        {
            return Groups.Sum(g => g.ElectedByAll.Count()).ToString();
        }
    }
}
