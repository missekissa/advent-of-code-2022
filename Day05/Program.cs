using Day05;
using Lib;
using System.Text.RegularExpressions;

//string path = "Input.txt";
string path = "Example.txt";

List<string> input = path.ReadInput().ParseInput(Environment.NewLine + Environment.NewLine).ToList();

//Parse stacks
Regex lastNumber = new(@"\d$");
int numberOfStacks = int.Parse(lastNumber.Match(input[0]).Value);

var test = input[0].Split(Environment.NewLine);
char test1 = test[2][1];
char test2 = test[2][5];
char test3 = test[2][9];

Console.WriteLine(test);

//Parse steps
Queue<Step> steps = new();
input[1].Split(Environment.NewLine).ToList().ForEach(line => steps.Enqueue(new Step(line)));

Console.WriteLine("Hello, World!");
Console.WriteLine(numberOfStacks);