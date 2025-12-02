using AdventOfCode.Models;

namespace AdventOfCode.Solutions.Year2021.Day01;

class Solution : SolutionBase
{
    public SonarSweep SonarSweep { get; set; }

    public Solution() : base(01, 2021, "Sonar Sweep")
    {
        SonarSweep = new SonarSweep(Input.ToIntArray("\n").ToList());
    }


    protected override string SolvePartOne()
    {
        return SonarSweep.GetIncreaseCount(SonarSweep.Measurements)
                            .ToString();
    }

    protected override string SolvePartTwo()
    {
        return SonarSweep.GetIncreaseCount(SonarSweep.Windows)
                            .ToString();
    }
}

