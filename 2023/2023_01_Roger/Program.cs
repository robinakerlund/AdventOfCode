

string[] input = File.ReadAllLines("../../../input.txt");

string[] exampleInput = {      
    "two1nine",         "eightwothree", 
    "abcone2threexyz",  "xtwone3four",      "4nineeightseven2", 
    "zoneight234",      "7pqrstsixteen"
};


Dictionary<string, string> digitConversionTable = new()
{
    {"one",     "1"},     {"two",     "2"},     {"three",   "3"}, 
    {"four",    "4"},     {"five",    "5"},     {"six",     "6"}, 
    {"seven",   "7"},     {"eight",   "8"},     {"nine",    "9"}
};


List<int> resultingDigitsPart1 = new();
List<int> resultingDigitsPart2 = new();


foreach (string line in input)
{
    List<string> digitsFound = new();


    for (int i = 0; i < line.Length; i++)
    {
        if (Int32.TryParse(line[i].ToString(), out int tempDigit))
        {
            digitsFound.Add(line[i].ToString());
        }


        List<string> analyzingTypedDigits = new();

        if (i <= line.Length - 5) { analyzingTypedDigits.Add(line.Substring(i, 5)); }
        if (i <= line.Length - 4) { analyzingTypedDigits.Add(line.Substring(i, 4)); }
        if (i <= line.Length - 3) { analyzingTypedDigits.Add(line.Substring(i, 3)); }
                    

        foreach (string potentialDigit in analyzingTypedDigits)
        {
            if (digitConversionTable.ContainsKey(potentialDigit))
            {
                digitsFound.Add(digitConversionTable[potentialDigit]);
            }
        }        
    }
        

    string digitAsString = $"{digitsFound[0]}{digitsFound.LastOrDefault()}";


    if (Int32.TryParse(digitAsString, out int digit))
    {
        resultingDigitsPart1.Add(digit);
        resultingDigitsPart2.Add(digit);
    }
}



int finalResultPart1 = resultingDigitsPart1.Sum(x => x);

Console.WriteLine(finalResultPart1);
