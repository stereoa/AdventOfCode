namespace AdventOfCode.Models
{
    public class GameCpuInstruction
    {
        public int Address { get; }
        public string Type { get; set; }
        public int Value { get; }

        public GameCpuInstruction(string instruction, int address)
        {
            var parameters = instruction.Split(" ");

            Address = address;
            Type = parameters[0];
            Value = Convert.ToInt32(parameters[1]);
        }
    }
}