namespace AdventOfCode.Models.Passports
{
    internal class CountryIdField : PassportField
    {

        public CountryIdField(string value) : base(value)
        {
        }

        public override bool IsValid => true;
    }
}