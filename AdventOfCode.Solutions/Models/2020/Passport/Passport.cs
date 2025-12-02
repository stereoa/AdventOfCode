using AdventOfCode.Models.Passports;

namespace AdventOfCode.Models
{
    public class Passport
    {
        public List<PassportField> Fields { get; set; } = new List<PassportField>();
        public bool HasValidData => Fields.All(f => f.IsValid);
        public bool HasValidFields => Fields.Count() == 8 ||
                                      Fields.Count(f => f is not CountryIdField) == 7;

    }
}