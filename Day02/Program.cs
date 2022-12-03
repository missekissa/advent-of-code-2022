using Lib;
using System.Diagnostics;
using System.Text;

string path = "Input.txt";

List<string> rounds = path.ReadInput().ParseInput(Environment.NewLine).ToList();

//1 Rock, 2 Paper and 3 Scissors
Dictionary<char, int> scores = new Dictionary<char, int>()
{
    {'A', 1},
    {'B', 2},
    {'C', 3},
    {'X', 1}, 
    {'Y', 2},
    {'Z', 3},
};

int silver = rounds.Select(x => RoundResult(x, scores) + scores[x[2]]).Sum();

var decrypt = rounds.Select(x => new string($"{x[0]} {Action(x, scores)}"));
int gold = decrypt.Select(x => RoundResult(x, scores) + scores[x[2]]).Sum();

Console.WriteLine(silver);
Console.WriteLine(gold);

static int RoundResult(string line, Dictionary<char, int> scores)
{
    int opponent = scores[line[0]];
    int response = scores[line[2]];

    if (opponent == response)
        return 3;

    if (opponent == 1 && response == 3)
        return 0;

    if (response == 1 && opponent == 3)
        return 6;

    return response > opponent ? 6 : 0;
}

static char Draw(string line)
{
    return line[0];
}

static char Win(string line, Dictionary<char, int> scores)
{
    char x = line[0];
    int opponent = scores[x];

    if (opponent == 3)
        return 'A';
    if (opponent == 1)
        return 'B';

    return 'C';
}

static char Lose(string line, Dictionary<char, int> scores)
{
    char x = line[0];
    int opponent = scores[x];

    if (opponent == 1)
        return 'C';

    if (opponent == 2)
        return 'A';

    return 'B';
}

static char Action(string line, Dictionary<char, int> scores)
{
    char action = line[2];

    if (action == 'Z')
        return Win(line, scores);
    if (action == 'X')
        return Lose(line, scores);
    return Draw(line);
}