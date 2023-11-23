string patToFile = "../../../input.txt";
List<int> readings = GetInputLinesAsInts(File.ReadAllLines(patToFile));


//  Part 1
int previousReading = 0;
int totalIncreasingReadings = 0;


//  Part 2
List<int> slidingWindows = new();
int previousSlidingWindow = 0;
int totalIncreasingSlidingWindowReadings = 0;


for (int i = 0;  i < readings.Count; i++)
{
    //  Part 1
    if (readings[i] > previousReading && previousReading != 0)
    {
        totalIncreasingReadings++;
    }
    previousReading = readings[i];


    //  Part 2
    if (i <= readings.Count - 3)
    {
        slidingWindows.Add(readings[i] + readings[i + 1] + readings[i + 2]);
    }
}

//  Part 2
foreach (int slidingWindow in slidingWindows)
{
    if (slidingWindow > previousSlidingWindow && previousSlidingWindow != 0)
    {
        totalIncreasingSlidingWindowReadings++;
    }
    previousSlidingWindow = slidingWindow;
}


Console.WriteLine("Part 1: " + totalIncreasingReadings);
Console.WriteLine("Part 2: " + totalIncreasingSlidingWindowReadings);

List<int> GetInputLinesAsInts(string[] input)
{
    List<int> result = new();

    foreach (string line in input)
    {
        if (Int32.TryParse(line, out int lineValue))
        {
            result.Add(lineValue);
        }
        else
        {
            Console.WriteLine("Something went wrong with the numbers");
            break;
        }
    }
    return result;
}
