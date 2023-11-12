

string patToFile = "../../../input.txt";
List<int> calorySums = new List<int>();
int elfSumOfCalories = 0;

foreach (string line in File.ReadAllLines(patToFile))
{
    if (Int32.TryParse(line, out int lineValue))
    {
        elfSumOfCalories += lineValue;
    }
    else
    {
        calorySums.Add(elfSumOfCalories);
        elfSumOfCalories = 0;
    }
}

calorySums.Sort();
calorySums.Reverse();

int sumOfTopThree = 0;

for (int i = 0; i < 3; i++)
{
    sumOfTopThree += calorySums[i];
}


Console.WriteLine($@"
The elf with highest amount of calories is carrying: {calorySums.Max()} calories
And the 3 elves with the highest amount of calories is carrying together: {sumOfTopThree} calories.
");