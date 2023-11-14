

/*  PART 1 

a, x = rock = 1p
b, y = paper = 2p
c, z = scissor = 3p

loss = 0p
tie = 3p
win = 6p
*/

/*  PART 2

a = rock = 1p
b = paper = 2p
c = scissor = 3p

x = loss = 0p
y = tie = 3p
z = win = 6p
*/


//  Reading in the strategy guide from input.txt
string pathToFile = "../../../input.txt";
List<string[]> strategyGuide = new();
 
foreach (string line in File.ReadAllLines(pathToFile))
{
    strategyGuide.Add(line.Split(" "));
}
//______________________________________


int totalScorePart1 = 0;
int totalScorePart2 = 0;

Dictionary<string, int> scoreTablePart1 = new()
{
    { "x", 1 },
    { "y", 2 },
    { "z", 3 },
    { "win", 6 },
    { "tie", 3 },
    { "loss", 0 }
};

Dictionary<string, int> scoreTablePart2 = new()
{
    { "a", 1 },
    { "b", 2 },
    { "c", 3 },
    { "x", 0 },
    { "y", 3 },
    { "z", 6 }
};


foreach (string[] round in strategyGuide)
{
    string opponent = round[0].ToLower();

    //  Part 1
    string me = round[1].ToLower();

    //  If i win
    if ( (opponent == "c" && me == "x") || (opponent == "a" && me == "y") || (opponent == "b" && me == "z") ) 
    { totalScorePart1 += scoreTablePart1["win"] + scoreTablePart1[me]; }

    //  If it is a tie
    else if ((opponent == "a" && me == "x") || (opponent == "b" && me == "y") || (opponent == "c" && me == "z") ) 
    { totalScorePart1 += scoreTablePart1["tie"] + scoreTablePart1[me]; }

    //  If it is a loss
    else { totalScorePart1 += scoreTablePart1["loss"] + scoreTablePart1[me]; }

    //  Part 2
    string outcome = round[1].ToLower();

    if (outcome == "y")
    {
        totalScorePart2 += scoreTablePart2["y"] + scoreTablePart2[opponent];
    }
    else if (outcome == "x")
    {
        if      (opponent == "a") { totalScorePart2 += scoreTablePart2["x"] + scoreTablePart2["c"]; }
        else if (opponent == "b") { totalScorePart2 += scoreTablePart2["x"] + scoreTablePart2["a"]; }
        else if (opponent == "c") { totalScorePart2 += scoreTablePart2["x"] + scoreTablePart2["b"]; }
    }
    else if (outcome == "z")
    {
        if      (opponent == "a") { totalScorePart2 += scoreTablePart2["z"] + scoreTablePart2["b"]; }
        else if (opponent == "b") { totalScorePart2 += scoreTablePart2["z"] + scoreTablePart2["c"]; }
        else if (opponent == "c") { totalScorePart2 += scoreTablePart2["z"] + scoreTablePart2["a"]; }
    }

}

Console.WriteLine("Total score according to my reasoning is: " + totalScorePart1);
Console.WriteLine("Total score if i follow the guide properly: " + totalScorePart2);