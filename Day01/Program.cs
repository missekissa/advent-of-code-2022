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

            var data = input.ParseInput(seperator).Select(x => x.Split(Environment.NewLine)
                .Select(int.Parse).ToList()).ToList().Select(x => x.Sum()).ToList();
                 
            Console.WriteLine(Part1(data));
            Console.WriteLine(Part2(data));            
        }

        private static int Part1(List<int> sums) =>
            sums.Max();

        private static int Part2(List<int> sums) =>
            sums.OrderByDescending(x => x).Take(3).Sum();

    }
}