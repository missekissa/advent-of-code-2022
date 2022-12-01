namespace Lib
{
    public static class Extensions
    {
        public static string ReadInput(this string fileLocation) =>
            File.ReadAllText(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, fileLocation));

        public static IEnumerable<string> ParseInput(this string input, string seperator) =>
            input.Split(seperator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

    }
}