using System.Text.RegularExpressions;

namespace AdventOfCode.Models.Passports
{
    internal class HairColorField : PassportField
    {
        public const string HAIR_COLOR_PATTERN = @"^#([a-f0-9]{6})$";

        public HairColorField(string value) : base(value)
        {
        }

        public override bool IsValid => new Regex(HAIR_COLOR_PATTERN).IsMatch(RawValue);
    }
}