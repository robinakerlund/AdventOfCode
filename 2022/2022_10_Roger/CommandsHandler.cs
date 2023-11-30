using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_10_Roger
{
    internal class CommandsHandler
    {
        public int CurrentCycle { get; set; } = 1;
        public int outputX { get; set; } = 1;

        public List<Command> commands = new List<Command>();
        

        public CommandsHandler(string[] input) 
        {
            foreach (string line in input)
            {
                commands.Add(new Command(line));

                if (line.Split(" ")[0] == "addx")
                {
                    commands.Add(new Command("noop"));
                }
            }
        }


        public void UpdateOutputX()
        {
            foreach (Command command in commands)
            {
                if (command.ExecutionCycle == CurrentCycle)
                {
                    outputX += command.Value;
                }
            }
        }
    }
}
