using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_02_Roger
{
    internal class Command
    {
        public string Cmd { get; set; }
        public int CmdValue { get; set; }

        public Command(string command, int commandValue) 
        {
            Cmd = command;
            CmdValue = commandValue;
        }
    }
}
