using Lib;

string path = "Input.txt";
string input = path.ReadInput();

int silver = FindMarker(input, 4);
int gold = FindMarker(input, 14);

Console.WriteLine(silver);
Console.WriteLine(gold);

static int FindMarker(string input, int length, int index = 0) 
{    
    if (input.Skip(index).Take(length).Distinct().Count() == length)
        return index + length; 

    return FindMarker(input, length, index + 1);
}