using AdventOfCode.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Models
{
    public class GameCpu
    {
        public IEnumerable<GameCpuInstruction> Instructions { get; set; }
        public int CurrentAddress { get; set; }
        public int Accumulator { get; set; }
        public bool IsRunning { get; private set; }
        public List<GameCpuInstruction> CallStack = new List<GameCpuInstruction>();

        public GameCpu(string bootCode)
        {
            Instructions = bootCode.SplitByNewline().Select((i, index) => new GameCpuInstruction(i, index));
        }

        public void Execute()
        {
            IsRunning = true;
            Accumulator = 0;
            CurrentAddress = 0;
            CallStack.Clear();

            while (IsRunning)
            {
                var instruction = Instructions.ElementAt(CurrentAddress);
                CurrentAddress++;

                if (CallStack.Any(c => c.Address == instruction.Address))
                {
                    IsRunning = false;
                    throw new InfiniteLoopException();
                }

                switch (instruction.Type)
                {
                    case "acc":
                        Accumulator += instruction.Value;
                        break;
                    case "jmp":
                        if (instruction.Value == 0)
                        {
                            throw new InfiniteLoopException();
                        }
                        CurrentAddress += instruction.Value - 1;
                        break;
                    case "nop":
                    default:
                        break;
                }

                CallStack.Add(instruction);

                if(CurrentAddress == Instructions.Count())
                {
                    IsRunning = false;
                }
            }
        }

        public GameCpu Repair()
        {
            var repairCandidates = Instructions.Where(i => i.Type != "acc");
            var repairAddress = 0;
            foreach (var candidate in repairCandidates)
            {
                SwapInstruction(candidate.Address);

                try
                {
                    Execute();
                    repairAddress = candidate.Address;
                    break;
                }
                catch (InfiniteLoopException ex)
                {
                    SwapInstruction(candidate.Address);
                }
            }
            return this;
        }

        private void SwapInstruction(int Address)
        {
            var instructions = Instructions.ToList();
            var instruction = instructions.ElementAt(Address);

            if (instruction.Type == "nop")
            {
                instruction.Type = "jmp";
            }
            else
            {
                instruction.Type = "nop";
            }

            Instructions = instructions;
        }
    }
}