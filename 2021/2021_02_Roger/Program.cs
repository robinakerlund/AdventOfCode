using _2021_02_Roger;
using System.Collections.Generic;

string pathToInput = "../../../input.txt";
var commands = GetCommands(File.ReadAllLines(pathToInput));


int horizontalPosition = 0;
int depth = 0;

foreach (var command in commands)
{
    if (command.Cmd == "forward") { horizontalPosition += command.CmdValue; }
    if (command.Cmd == "down") {  depth += command.CmdValue; }
    if (command.Cmd == "up") { depth -= command.CmdValue; }
}

Console.WriteLine($"Horizontal Position is now: {horizontalPosition} and the Depth is: {depth}");
Console.WriteLine($"The answer ro the problem is {horizontalPosition * depth}");


List<Command> GetCommands(string[] inputArray)
{
    List<Command> commands = new List<Command>();

    foreach (var line in inputArray)
    {
        string[] inputLineArray = line.Split(" ");
        string command = inputLineArray[0];

        if (Int32.TryParse(inputLineArray[1], out int commandValue))
        {
            commands.Add( new Command(command, commandValue) );
        }
        else
        {
            Console.WriteLine("something worng with the parser");
            Console.ReadKey();
            break;
        }
    }

    return commands;
}