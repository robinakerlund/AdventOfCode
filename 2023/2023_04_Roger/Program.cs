string[] input = File.ReadAllLines("../../../input.txt");

string[] exampleInput =
{
    "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
    "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19",
    "Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1",
    "Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83",
    "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36",
    "Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
};

int sumOfWinnings = 0;

foreach (string card in input)
{
    List<int> myNumbers = ConvertStringArrayToIntArray( card.Split(':')[1].Split('|')[0].Split(" ") );
    List<int> drawnNumbers = ConvertStringArrayToIntArray( card.Split(":")[1].Split("|")[1].Split(" ") );
    int AmmountOfWinnings = 0;

    foreach (int number in myNumbers )
    {
        if (drawnNumbers.Contains(number))
        {
            AmmountOfWinnings++;
        }
    }
    sumOfWinnings += Convert.ToInt32( Math.Pow(2, AmmountOfWinnings - 1) );

    Console.WriteLine("amount of winnings: " + AmmountOfWinnings);
    Console.WriteLine("sum atm: " + sumOfWinnings);
}

Console.WriteLine(sumOfWinnings);

List<int> ConvertStringArrayToIntArray(string[] input)
{
    List<int> output = new();

    for (int i = 0; i < input.Length; i++)
    {
        if (Int32.TryParse(input[i], out int digit))
        {
            output.Add(digit);
        }
    }

    return output;
}