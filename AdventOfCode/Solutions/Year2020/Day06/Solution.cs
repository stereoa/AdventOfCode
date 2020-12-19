using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    class Day06 : ASolution
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
