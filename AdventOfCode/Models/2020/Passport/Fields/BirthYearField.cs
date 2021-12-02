namespace AdventOfCode.Models.Passports
{
    internal class BirthYearField : PassportYearField
    {
        public const int MIN_BIRTH_YEAR = 1920;
        public const int MAX_BIRTH_YEAR = 2002;

        public BirthYearField(string value) : base(value, MIN_BIRTH_YEAR, MAX_BIRTH_YEAR)
        {
        }
    }
}