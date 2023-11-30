using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_10_Roger
{
    internal class Command
    {
        public string Name { get; } = string.Empty;
        public int Value { get; }
        public int CyclesToComplete { get; }
        public int ExecutionCycle { get; set; }


        public Command(string input) 
        {
            if (input.Split(" ")[0] == "noop")
            {
                Name = input.Split(" ")[0];
                Value = 0;
                CyclesToComplete = 1;                
            }
            else if (input.Split(" ")[0] == "addx")
            {
                Name = input.Split(" ")[0];
                Value = Convert.ToInt32(input.Split(" ")[1]);
                CyclesToComplete = 2;                
            }
        }
    }
}
