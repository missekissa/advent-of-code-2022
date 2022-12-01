using Lib;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day01
{
    public class Program
    {
                                   
        static void Main(string[] args)
        {
            string path = "Input.txt";
            string input = path.ReadInput();

            string seperator = Environment.NewLine + Environment.NewLine;

            var data = input.ParseInput(seperator).Select(x => x.Split(Environment.NewLine).Select(int.Parse).ToList()).ToList();

            int maksimi = Part1(data);
            Console.WriteLine(maksimi);
            
        }

        //private static int Part1(List<List<int>> calories)
        //{
        //    return calories.Select(x => x.Sum()).Max();
        //}

        private static int Part1(List<List<int>> calories) =>
          calories.Select(x => x.Sum()).Max();

    }
}