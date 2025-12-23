using AdventOfCode.AdventOfCode.Solutions.Models;

namespace AdventOfCode.Solutions.Year2025.Day03;

class Solution : SolutionBase
{
    public Solution() : base(03, 2025, "Lobby") { }

    protected override string? SolvePartOne()
    {
        var inputs = Input.SplitByNewline();
        var banks = inputs.Select(x => new BatteryBank(x));

        var totalJoltage = banks.Sum(x => x.MaximumJoltage);

        return totalJoltage.ToString();
    }

    protected override string? SolvePartTwo()
    {
        var inputs = Input.SplitByNewline();
        var banks = inputs.Select(x => new BatteryBank(x, 12));

        var totalJoltage = banks.Sum(x => x.MaximumJoltage);

        return totalJoltage.ToString();
    }
}
