using Lib;
using System.Runtime.CompilerServices;

string path = "Input.txt";

List<List<string>> rucksacks = path.ReadInput().ParseInput(Environment.NewLine).Select(x => getCompartments(x).ToList()).ToList();;

string lowercaseItems = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
string uppercaseItems = lowercaseItems.ToUpper();
string priorities = string.Concat("0", lowercaseItems, uppercaseItems);

int silver = rucksacks.Select(x => FindItem(x[0], x[1]))
    .Select(x => priorities.IndexOf(x)).Sum();

var part2 = path.ReadInput().ParseInput(Environment.NewLine).ToList();

var test = ParseGroups(part2).Select(x => FindBadge(x)).ToList();

var gold = ParseGroups(part2).Select(x => FindBadge(x))
    .Select(x => priorities.IndexOf(x)).Sum();

Console.WriteLine(silver);
Console.WriteLine(gold);


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

static IEnumerable<IEnumerable<string>> ParseGroups(List<string> rucksacks)
{
    for (int i = 0; i < rucksacks.Count; i += 3)
    {
        yield return rucksacks.GetRange(i, 3);
    }
}

static char FindBadge(IEnumerable<string> group, int i = 0)
{
    char item = group.First()[i];

    if (group.Skip(1).All(x => x.Contains(item)))
        return item;

    return FindBadge(group, i + 1);
}