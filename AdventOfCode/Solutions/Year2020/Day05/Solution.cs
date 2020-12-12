using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    class Day05 : ASolution
    {
        public IEnumerable<BoardingPass> BoardingPasses { get; }

        public Day05() : base(05, 2020, "")
        {
            var input = Input.SplitByNewline();
            BoardingPasses = input.Select(i => new BoardingPass(i));
        }


        protected override string SolvePartOne()
        {
            return BoardingPasses.Max(b => b.SeatId).ToString();
        }

        protected override string SolvePartTwo()
        {
            var passes = BoardingPasses.OrderBy(b => b.SeatId).ToList();
            for (var i = 0; i < passes.Count() - 1; i++)
            {
                if(passes[i].SeatId +2 == passes[i+1].SeatId)
                {
                    var targetSeatId = passes[i].SeatId + 1;
                    return targetSeatId.ToString();
                }
            }
            return "Seat not found!";
        }
    }
}
