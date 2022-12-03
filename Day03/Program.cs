// See https://aka.ms/new-console-template for more information

using Lib;

//string path = "Example.txt";
string path = "Input.txt";

List<List<string>> rucksacks = path.ReadInput().ParseInput(Environment.NewLine).Select(x => getCompartments(x).ToList()).ToList();;

string lowercaseItems = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
string uppercaseItems = lowercaseItems.ToUpper();
string priorities = string.Concat("0", lowercaseItems, uppercaseItems);

int silver = rucksacks.Select(x => FindItem(x[0], x[1]))
    .Select(x => priorities.IndexOf(x)).Sum();

Console.WriteLine(silver);


static List<string> getCompartments(string rucksack)
{
    int half = rucksack.Length / 2;
    return new List<string>() { new string(rucksack.Take(half).ToArray()), new string(rucksack.Skip(half).ToArray()) };

}

static char FindItem(string firstRucksack, string secondRucksack, int index = 0)
{
    char item = firstRucksack[index];
    if (secondRucksack.Contains(item))
        return item;

    return FindItem(firstRucksack, secondRucksack, index + 1);       
}

