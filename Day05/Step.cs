using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day05
{
    public class Step
    {
        public Step(int move, int from, int to)
        {
            Move = move;
            From = from;
            To = to;
        }

        public Step(string line)
        {
            var matches = number.Matches(line).Select(x => int.Parse(x.Value)).ToArray();
            Move = matches[0];
            From = matches[1];
            To = matches[2];           
        }

        int Move { get; set; }
        int From { get; set; }
        int To { get; set; }

        static readonly Regex number = new Regex(@"\d+");

        public override string? ToString()
        {
            return $"move {Move} from {From} to {To}";
        }
    }
}
