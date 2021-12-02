using System.Text.RegularExpressions;

namespace AdventOfCode.Models.Passports
{
    internal class PassportIdField : PassportField
    {
        public const string PASSPORT_ID_PATTERN =@"^([0-9]{9})$";
        public PassportIdField(string value) : base(value)
        {
        }

        public override bool IsValid => new Regex(PASSPORT_ID_PATTERN).IsMatch(RawValue);
    }
}