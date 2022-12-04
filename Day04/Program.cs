using Lib;
using System.Text.RegularExpressions;

string path = "Input.txt";

List<string> lines = path.ReadInput().ParseInput(Environment.NewLine).ToList();

Regex number = new Regex(@"\d+");

var data = lines.Select(x => CreatePair(x, number)).ToList();

var silver = data.Select(x => Silver(x)).Sum();
var gold = data.Select(x => Gold(x)).Sum();

Console.WriteLine(silver);
Console.WriteLine(gold);


static int Silver(Dictionary<string, List<int>> sections)
{
    var firstPair = sections["first"];
    var secondPair = sections["second"];

    if (firstPair.All(x => secondPair.Contains(x)))
        return 1;

    if (secondPair.All(x => firstPair.Contains(x)))
        return 1;

    return 0;     
}

static int Gold(Dictionary<string, List<int>> sections)
{
    var firstPair = sections["first"];
    var secondPair = sections["second"];

    if (firstPair.Any(x => secondPair.Contains(x)))
        return 1;

    if (secondPair.Any(x => firstPair.Contains(x)))
        return 1;

    return 0;
}


static Dictionary<string, List<int>> CreatePair(string line, Regex number)
{
    var matches = number.Matches(line);

    int first = int.Parse(matches[0].Value);
    int second = int.Parse(matches[1].Value);
    List<int> firstPair = Enumerable.Range(first, second - first + 1).ToList();

    int third = int.Parse(matches[2].Value);
    int fourth = int.Parse(matches[3].Value);
    List<int> secondPair = Enumerable.Range(third, fourth - third + 1).ToList();

    return new Dictionary<string, List<int>>
    {
        { "first", firstPair },
        { "second", secondPair }
    };
}