namespace AdventOfCode.Models
{
    public class SubmarineInstruction
    {
        public int Distance;
        public string Direction;

        public SubmarineInstruction(string input)
        {
            var data = input.Split(" ");
            Direction = data[0];
            Distance = Convert.ToInt32(data[1]);
        }
    }

}
