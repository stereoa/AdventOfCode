namespace AdventOfCode.Models.Passports
{
    internal class HeightField : PassportField
    {
        public const int MIN_CM_UNITS = 150;
        public const int MAX_CM_UNITS = 193;
        public const int MIN_IN_UNITS = 59;
        public const int MAX_IN_UNITS = 76;
        public UnitType Units { get; }

        public int UnitMin => Units == UnitType.Centimeters ? MIN_CM_UNITS : MIN_IN_UNITS;
        public int UnitMax => Units == UnitType.Centimeters ? MAX_CM_UNITS : MAX_IN_UNITS;
        public int UnitAmount { get; private set; }

        public HeightField(string value) : base(value)
        {
            var valid = true;

            var units = value.Substring(value.Length - 2);
            if (units.Equals("cm"))
            {
                Units = UnitType.Centimeters;
            }
            else if (units.Equals("in"))
            {
                Units = UnitType.Inches;
            }
            else
            {
                Units = UnitType.Unknown;
                valid = false;
            }

            if (valid)
            {
                var amount = value.Substring(0, value.Length - 2);
                UnitAmount = int.Parse(value.Substring(0, value.Length - 2));
            }
        }

        public override bool IsValid => Units != UnitType.Unknown &&
                                                (UnitAmount >= UnitMin && UnitAmount <= UnitMax);

    }

    public enum UnitType
    {
        Unknown,
        Centimeters,
        Inches
    }
}