
string[] input = File.ReadAllLines("../../../input.txt");

/* From example for testing
string[] input = {
    "00100",
    "11110",
    "10110",
    "10111",
    "10101",
    "01111",
    "00111",
    "11100",
    "10000",
    "11001",
    "00010",
    "01010"
};*/


//  Part 1 Power Consumption
//int powerConsumption = GetPowerConsumption(input);
//Console.WriteLine(powerConsumption);



//  Part 2 Life Support Rating
int lifeSupportRating = GetLifeSupportRating(input);
Console.WriteLine(lifeSupportRating);




int GetLifeSupportRating(string[] input)
{
    int oxygenGenerationRating = GetRatingsForLifesupport(input.ToList(), true);
    int co2ScrubbingRating = GetRatingsForLifesupport(input.ToList(), false);

    Console.WriteLine("oxyRate: " + oxygenGenerationRating);
    Console.WriteLine("co2Rate: " + co2ScrubbingRating);

    return oxygenGenerationRating * co2ScrubbingRating;    
}

int GetRatingsForLifesupport(List<string> input, bool oxygenRating)
{
    //int bitPosition = 0;
    char toRemove = 'a';
    List<int> indexesToRemove;

    for (int bitPosition = 0; bitPosition < input[0].Length; bitPosition++)
    {
        int zero = 0;
        int one = 0;
        indexesToRemove = new();



        foreach (string inputLine in input)
        {
            if (inputLine[bitPosition] == '0') zero++;
            if (inputLine[bitPosition] == '1') one++;
        }



        if (oxygenRating)
        {
            if (zero > one) toRemove = '1';
            if (zero < one) toRemove = '0';
            if (zero == one) toRemove = '0';
        }
        else
        {
            if (zero > one) toRemove = '0';
            if (zero < one) toRemove = '1';
            if (zero == one) toRemove = '1';
        }



        for (int inputIndex = 0; inputIndex < input.Count; inputIndex++)
        {
            if (input[inputIndex][bitPosition] == toRemove)
            {
                indexesToRemove.Add(inputIndex);
            }
        }



        for (int index = indexesToRemove.Count - 1; index >= 0; index--)
        {
            input.RemoveAt(indexesToRemove[index]);
        }



        if (input.Count <= 1)
        {
            Console.WriteLine("breaking because input list is: " + input.Count);
            break;
        }

        if (input.Count > 1 && bitPosition == input[0].Length - 1)
        {
            bitPosition = 0;
            Console.WriteLine("changing bitPosition back to 0");
        }
    }


    return Convert.ToInt32(input[0], 2);
}


int GetPowerConsumption(string[] input)
{

    List<string> gammaValues = new();
    List<string> epsilonValues = new();

    for (int i = 0; i < input[0].Length; i++)
    {

        int zero = 0;
        int one = 0;

        foreach (string line in input)
        {
            if (line[i] == '0')
            {
                zero++;
            }
            else
            {
                one++;
            }
        }

        if (zero > one)
        {
            gammaValues.Add("0");
            epsilonValues.Add("1");
        }
        else
        {
            gammaValues.Add("1");
            epsilonValues.Add("0");
        }
    }

    string gammaBinary = String.Join("", gammaValues.ToArray());
    int gammaDecimal = Convert.ToInt32(gammaBinary, 2);

    string epsilonBinary = String.Join("", epsilonValues.ToArray());
    int epsilonDecimal = Convert.ToInt32(epsilonBinary, 2);

    int powerConsumption = gammaDecimal * epsilonDecimal;

    return powerConsumption;
}

