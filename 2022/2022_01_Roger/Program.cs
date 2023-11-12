

string patToFile = "../../../input.txt";
List<int> sumsOfAllElfsCalories = new List<int>();
int sumOfElfCalories = 0;

foreach (string line in File.ReadAllLines(patToFile))
{
    if (Int32.TryParse(line, out int lineValue))
    {
        sumOfElfCalories += lineValue;
    }
    else
    {
        sumsOfAllElfsCalories.Add(sumOfElfCalories);
        sumOfElfCalories = 0;
    }
}

sumsOfAllElfsCalories.Sort();
sumsOfAllElfsCalories.Reverse();

int sumOfTopThreeElfs = 0;

for (int i = 0; i < 3; i++)
{
    sumOfTopThreeElfs += sumsOfAllElfsCalories[i];
}


Console.WriteLine($@"
The elf with highest amount of calories is carrying: {sumsOfAllElfsCalories.Max()} calories
And the 3 elves with the highest amount of calories is carrying together: {sumOfTopThreeElfs} calories.
");
