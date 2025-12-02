using AdventOfCode.AdventOfCode.Solutions.Models;

namespace AdventOfCode.Solutions.Year2025.Day01;

class Solution : SolutionBase
{
    public Solution() : base(01, 2025, "Secret Entrance") { }

    protected override string? SolvePartOne()
    {
        var directions = Input.SplitByNewline();
        var dial = new Dial();
        dial.ProcessDirections(directions);
        return dial.ZeroStopCount.ToString();
    }

    protected override string? SolvePartTwo()
    {
        var directions = Input.SplitByNewline();
        var dial = new Dial();
        dial.ProcessDirections(directions);
        return dial.ZeroTotalCount.ToString();
    }
}
