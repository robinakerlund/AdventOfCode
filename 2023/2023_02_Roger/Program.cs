


string[] input = File.ReadAllLines("../../../input.txt");
string[] exampleInput =
{
    "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
    "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
    "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
    "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
    "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
};

#region     PART 1

List<int> gameIdToSumUp = new();

foreach (string inputLine in input)
{
    int id = Convert.ToInt32( inputLine.Split(":")[0].Split(" ")[1] );

    List<int> ammounts = new();

    foreach (string round in inputLine.Split(":")[1].Split(";") )
    {
        foreach (string stone in round.Split(","))
        {
            string color = stone.Split(" ")[2];
            int ammount = Convert.ToInt32(stone.Split(" ")[1]);

            if ((color == "red" &&  ammount > 12) ||
                (color == "green" && ammount > 13) ||
                (color == "blue" && ammount > 14) )
            {
                ammounts.Add( ammount );
            }
        }
    }

    if (ammounts.Count == 0)
    {
        gameIdToSumUp.Add(id);
    }
}


int sumOfAmmounts = 0;

foreach (int id in gameIdToSumUp)
{
    sumOfAmmounts += id;
}

Console.WriteLine("The answer to part 1: " + sumOfAmmounts);
#endregion


#region PART 2

int sumOfPowersOfSets = 0;

foreach (string game in input)
{
    int red = 0, green = 0, blue = 0;

    foreach (string round in game.Split(":")[1].Split(";"))
    {
        foreach (string stone in round.Split(","))
        {
            string color = stone.Split(" ")[2];
            int ammount = Convert.ToInt32(stone.Split(" ")[1]);

            if (color == "red" && ammount > red) { red = ammount; }
            if (color == "green" && ammount > green) { green = ammount; }
            if (color == "blue" && ammount > blue) {  blue = ammount; }
        }
    }

    int multiplied = red * green * blue;
    sumOfPowersOfSets += multiplied;
}

Console.WriteLine("The ansswer to part 2 is: " + sumOfPowersOfSets);
#endregion