using System.Linq;

namespace AdventOfCode.Models.Passports
{
    internal class EyeColorField : PassportField
    {
        private string[] _validEyeColors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
        public EyeColorField(string value) : base(value)
        {
        }

        public override bool IsValid => _validEyeColors.Contains(RawValue);
    }
}