

/*  PART 1

a, x = rock = 1p
b, y = paper = 2p
c, z = scissor = 3p

loss = 0p
tie = 3p
win = 6p
*/


string pathToFile = "../../../input.txt";
List<string[]> strategyGuide = new();
int totalScore = 0;

Dictionary<string, int> scoreTable = new()
{
    { "x", 1 },
    { "y", 2 },
    { "z", 3 },
    { "win", 6 },
    { "tie", 3 },
    { "loss", 0 }
};


//  Reading in the strategy guide from input.txt 
foreach (string line in File.ReadAllLines(pathToFile))
{
    strategyGuide.Add(line.Split(" "));
}


foreach (string[] round in strategyGuide)
{
    string opponent = round[0].ToLower();
    string me = round[1].ToLower();

    //  If i win
    if ((opponent == "c" && me == "x") ||
        (opponent == "a" && me == "y") ||
        (opponent == "b" && me == "z"))
    {
        totalScore += scoreTable["win"] + scoreTable[me];
    }

    //  If it is a tie
    else if ((opponent == "a" && me == "x") ||
        (opponent == "b" && me == "y") ||
        (opponent == "c" && me == "z") )
    {
        totalScore += scoreTable["tie"] + scoreTable[me];
    }

    //  If it is a loss
    else
    {
        totalScore += scoreTable["loss"] + scoreTable[me];
    }
}

Console.WriteLine("Total score according to my reasoning is: " + totalScore);




/*  PART 2

a = rock = 1p
b = paper = 2p
c = scissor = 3p

x = loss = 0p
y = tie = 3p
z = win = 6p
*/