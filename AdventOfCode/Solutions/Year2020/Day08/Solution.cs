using AdventOfCode.Models;

namespace AdventOfCode.Solutions.Year2020
{

    class Day08 : ASolution
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
