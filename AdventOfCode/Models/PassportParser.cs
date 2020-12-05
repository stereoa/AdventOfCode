using AdventOfCode.Models.Passports;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode.Models
{
    public static class PassportParser
    {
        public static IEnumerable<Passport> Parse(string input)
        {
            var passports = input.Split("\n\n");
            var parsedPassports = new List<Passport>();

            foreach(var passport in passports)
            {
                var currentPassport = new Passport();

                var fields = Regex.Split(passport, @"[\s\n]");

                foreach(var field in fields)
                {
                    var fieldInfo = field.Split(":");
                    var name = fieldInfo[0];
                    var value = fieldInfo[1];
                    PassportField currentField = null;
                    switch(name)
                    {
                        case "byr":
                            currentField = new BirthYearField(value);
                            break;
                        case "iyr":
                            currentField = new IssueYearField(value);
                            break;
                        case "eyr":
                            currentField = new ExpirationYearField(value);
                            break;
                        case "hgt":
                            currentField = new HeightField(value);
                            break;
                        case "hcl":
                            currentField = new HairColorField(value);
                            break;
                        case "ecl":
                            currentField = new EyeColorField(value);
                            break;
                        case "pid":
                            currentField = new PassportIdField(value);
                            break;
                        case "cid":
                            currentField = new CountryIdField(value);
                            break;
                    }

                    if(currentField != null)
                    {
                        currentPassport.Fields.Add(currentField);
                    }
                }
                parsedPassports.Add(currentPassport);
            }
            return parsedPassports;
        }
    }
}