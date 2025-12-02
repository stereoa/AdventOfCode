using AdventOfCode.AdventOfCode.Solutions.Models;

namespace AdventOfCode.Solutions.Year2025.Day02;

class Solution : SolutionBase
{
    public Solution() : base(02, 2025, "") { }

    protected override string? SolvePartOne()
    {
        var ranges = Input.Split(",");
        var validator = new IdValidator();
        var invalidIds = validator.FindInvalidIds(ranges).ToList();
        var sum = invalidIds.Sum();
        return sum.ToString();
    }

    protected override string? SolvePartTwo()
    {
        var ranges = Input.Split(",");
        var validator = new IdValidator();
        var invalidIds = validator.FindInvalidIds(ranges, true).ToList();
        var sum = invalidIds.Sum();
        return sum.ToString();
    }
}
