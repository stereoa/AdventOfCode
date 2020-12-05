namespace AdventOfCode.Models.Passports
{
    public abstract class PassportField
    {
        public string RawValue { get; }
        public PassportField(string rawValue)
        {
            RawValue = rawValue;
        }
        public abstract bool IsValid { get; }
    }
}