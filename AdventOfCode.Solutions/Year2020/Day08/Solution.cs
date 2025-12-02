using AdventOfCode.Models;
using AdventOfCode.Solutions;

namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day08
{

    class Day08 : SolutionBase
    {
        GameCpu Cpu { get; set; }

        public Day08() : base(08, 2020, "")
        {
            Cpu = new GameCpu(Input);
        }

        protected override string SolvePartOne()
        {
            try
            {
                Cpu.Execute();
            }
            catch (InfiniteLoopException ex)
            {

            }
            return Cpu.Accumulator.ToString();
        }

        protected override string SolvePartTwo()
        {
            Cpu.Repair().Execute();
            return Cpu.Accumulator.ToString();
        }
    }
}
