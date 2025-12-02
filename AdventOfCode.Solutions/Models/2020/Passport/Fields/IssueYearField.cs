namespace AdventOfCode.Models.Passports
{
    internal class IssueYearField : PassportYearField
    {
        public const int MIN_ISSUE_YEAR = 2010;
        public const int MAX_ISSUE_YEAR = 2020;

        public IssueYearField(string value) : base(value, MIN_ISSUE_YEAR, MAX_ISSUE_YEAR)
        {
        }
    }
}