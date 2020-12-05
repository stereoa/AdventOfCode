namespace AdventOfCode.Models.Passports
{
    public class PassportYearField : PassportField
    {
        public int Year;
        public int Min;
        public int Max;

        protected PassportYearField(string value, int min, int max) : base(value)
        {
            this.Year = int.Parse(value);
            this.Min = min;
            this.Max = max;
        }

        public override bool IsValid => Year >= Min && Year <= Max;
    }
}