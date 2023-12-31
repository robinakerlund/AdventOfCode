﻿// Dictionary because it feels most logical to use an KeyValuePair (where key is an int, that counts the elfs, and the value is the amount of calories).
Dictionary<int, float> elfKcal = new Dictionary<int, float>();

int elfCount = 0;
float calories = 0;
float sumOfTopThree = 0;

// Using statement here, because it disposes automatically after it is done.
using (var sr = new StreamReader("input.txt"))
{
    var textRow = sr.ReadLine();

    LoopElfs(textRow, sr);
}

// Sorting the dictionary here to find the elf with the highest amount of calories, that will be added to the variable firstElf
var sortedDict = elfKcal.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
var firstElf = sortedDict.FirstOrDefault();

// Output 1
Console.WriteLine($"Elf no {firstElf.Key} is the elf with the highest amount of calories with a total of {firstElf.Value} calories.");

for (int i = 0; i < 3; i++)
{
    sumOfTopThree += sortedDict.ElementAt(i).Value;
}

// Output 2
Console.WriteLine($"The top 3 elfs have a total of {sumOfTopThree} calories");


void LoopElfs(string? textRow, StreamReader sr)
{
    // A while loop aslong as there is a row to read.
    while (textRow != null)
    {
        if (textRow.Length < 1)
        {
            elfCount++;
            elfKcal.Add(elfCount, calories);
            calories = 0;
        }
        else
        {
            calories += Int32.Parse(textRow);
        }

        textRow = sr.ReadLine();
    }
}