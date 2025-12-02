namespace AdventOfCode.Models.Passports
{
    internal class ExpirationYearField : PassportYearField
    {
        public const int MIN_EXPIRATION_YEAR = 2020;
        public const int MAX_EXPIRATION_YEAR = 2030;
        public ExpirationYearField(string value):base(value, MIN_EXPIRATION_YEAR, MAX_EXPIRATION_YEAR)
        {
        }

    }
}