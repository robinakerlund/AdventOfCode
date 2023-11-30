
using _2022_10_Roger;

string[] input = File.ReadAllLines("../../../input.txt");
string[] exampleInput = File.ReadAllLines("../../../exampleInput.txt");
string[] smallExample = { "noop", "addx 3", "addx -5", "noop", "noop" };

int[] cyclesToAnalyze = { 20, 60, 100, 140, 180, 220 };
Dictionary<int, int> analyticsReport = new();



CommandsHandler commandsHandler = new(input);



foreach (var command in commandsHandler.commands)
{
    command.ExecutionCycle = commandsHandler.CurrentCycle + command.CyclesToComplete;

    Console.WriteLine($@"
        ___________________________________________________________________________________________
        Current cycle:              {commandsHandler.CurrentCycle}
        OutputX at start of cycle:  {commandsHandler.outputX}
        --------------------
            Command: {command.Name}
            value: {command.Value}
            Execute on cycle: {command.ExecutionCycle}       
        ________________________________________________
    ");

    

    commandsHandler.UpdateOutputX();



    if (cyclesToAnalyze.Contains(commandsHandler.CurrentCycle))
    {
        analyticsReport.Add( commandsHandler.CurrentCycle, commandsHandler.outputX );
    }



    Console.WriteLine($@"
        OutputX at the end of cycle:    {commandsHandler.outputX}     
        ______________________________________________________________________________________________
    ");



    commandsHandler.CurrentCycle++;
}



int analyticResult = 0;

foreach (int analyticKey in analyticsReport.Keys)
{
    analyticResult += analyticKey * analyticsReport[analyticKey];
}

Console.WriteLine("The result of the analyze is: " + analyticResult);