
// 533421 is too low

string[] input = File.ReadAllLines("../../../input.txt");

Console.WriteLine($"Ammount of lines: {input.Length} - Chars in each: {input[0].Length}");

string[] exampleInput =
{
"..#.....",
".......2",
"1.....%."
};

//string[,] schematic = Get2dArray(exampleInput);
string[,] schematic = Get2dArray(input);
List<string> parts = new();

for (int row = 0; row < schematic.GetLength(0); row++)
{
    string part = string.Empty;
    bool isPart = false;

    for (int col = 0; col < schematic.GetLength(1); col++)
    {
        if (Int32.TryParse(schematic[row, col], out int singleDigit))
        {
            part += singleDigit.ToString();

            if (CheckIf_IsPart(schematic, row, col))
            {
                isPart = true;
            }

        }
        else
        {         
            if (isPart)
            {
                parts.Add(part);
                isPart = false;
            }
            
            part = string.Empty;
            
        }

    }
    
}

int sum = 0;
foreach (string part in parts)
{
    sum += Convert.ToInt32(part);
    Console.WriteLine(Convert.ToInt32(part));
}

Console.WriteLine(sum);

string[,] Get2dArray(string[] input)
{
    string[,] output = new string[input.Length, input[0].Length + 1];

    for (int i = 0; i < input.Length; i++)
    {
        for (int j = 0; j < input[i].Length; j++)
        {
            output[i, j] = input[i][j].ToString();
        }
        output[i, input[i].Length] = ".";
    }

    return output;
}
bool CheckIf_IsPart(string[,] arrayToCheck, int row, int col)
{
    string[] symbolsToIgnore = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "."};
    //string[] symbolsToIgnore = { "." };

    if (col > 0)
    {
        if (!symbolsToIgnore.Contains(arrayToCheck[row, col - 1]))
        {            
            return true;
        }
    }
    if (col < arrayToCheck.GetLength(1) - 1)
    {        
        if (!symbolsToIgnore.Contains(arrayToCheck[row, col + 1]))
        {
            return true;
        }
    }
    if (row > 0)
    {
        if (!symbolsToIgnore.Contains(arrayToCheck[row - 1, col]))
        { 
            return true; 
        }
        if (col > 0 && !symbolsToIgnore.Contains(arrayToCheck[row - 1, col - 1]))
        {
            return true;
        }
        if (col < arrayToCheck.GetLength(1) - 1 && !symbolsToIgnore.Contains(arrayToCheck[row - 1, col + 1]))
        {
            return true;
        }
    }
    if (row < arrayToCheck.GetLength(0) - 1)
    {
        if (!symbolsToIgnore.Contains(arrayToCheck[row + 1, col]))
        {
            return true;
        }
        if (col > 0 && !symbolsToIgnore.Contains(arrayToCheck[row + 1, col - 1]))
        {
            return true;
        }
        if (col < arrayToCheck.GetLength(1) - 1 && !symbolsToIgnore.Contains(arrayToCheck[row + 1, col + 1]))
        {
            return true;
        }
    }

    return false;
}