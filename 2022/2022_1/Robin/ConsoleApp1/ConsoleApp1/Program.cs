// Dictionary because it feels most logical to use an KeyValuePair (where key is an int, that counts the elfs, and the value is the amount of calories).
Dictionary<int, float> elfKcal = new Dictionary<int, float>();

// Using statement here, because it disposes automatically after it is done.
using (var sr = new StreamReader("input.txt"))
{
    int elfCount = 0;
    float kcal = 0;
    var textRow = sr.ReadLine();

    // A while loop aslong as there is a row to read.
    while (textRow != null)
    {
        if (textRow.Length < 1)
        {
            elfCount++;
            elfKcal.Add(elfCount, kcal);
            kcal = 0;
        }
        else
        {
            kcal += Int32.Parse(textRow);
        }

        textRow = sr.ReadLine();
    }
}
// Sorting the dictionary here to find the elf with the highest amount of calories, that will be added to the variablie firstElf
var sortedDict = elfKcal.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
var firstElf = sortedDict.FirstOrDefault();

// Output
Console.WriteLine($"Elf no {firstElf.Key} is the elf with the highest amount of calories with a total of {firstElf.Value} calories.");