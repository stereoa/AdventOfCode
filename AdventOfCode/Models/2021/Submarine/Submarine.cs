using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Models
{
    public class Submarine
    {
        public double X;
        public double Y;
        public double Aim;

        public void Pilot(IEnumerable<SubmarineInstruction> instructions, bool useAim = false)
        {
            foreach(var instruction in instructions)
            {
                Move(instruction, useAim);
            }
        }

        public void Move(SubmarineInstruction instruction, bool useAim = false)
        {
            if (instruction.Direction == "forward")
            {
                X += instruction.Distance;
                if(useAim)
                {
                    Y += Aim * instruction.Distance;
                }
            }
            else if (instruction.Direction == "up")
            {
                if (useAim)
                {
                    Aim -= instruction.Distance;
                }
                else
                {
                    Y -= instruction.Distance;
                }
            }
            else if (instruction.Direction == "down")
            {
                if(useAim)
                {
                    Aim += instruction.Distance;
                }
                else
                {
                    Y += instruction.Distance;
                }
            }
        }

    }
}
