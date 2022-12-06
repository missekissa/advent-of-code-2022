using Lib;

string path = "Input.txt";
//string path = "Example.txt";

string input = path.ReadInput();

int silver = Silver(input);

Console.WriteLine(silver);

static int Silver(string input, int start = 0, int end = 4)
{   
    if (input.Skip(start).Take(end).Distinct().Count() == 4)
        return start + end; 

    return Silver(input, start + 1, end);
}