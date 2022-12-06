using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class SupplyStacks
    {
        int NumberOfStacks { get; set; }
        Dictionary<int, Stack<string>> Stacks { get; set; }

        public SupplyStacks(int numberOfStacks, string input)
        {
            NumberOfStacks = numberOfStacks;
            Stacks = Parser(input);                
        }

        private Dictionary<int, Stack<string>> Parser (string input)
        {
            Dictionary<int, Stack<string>> stacks = new();
            for (int i = 1; i <= NumberOfStacks; i ++)
            {
                stacks.Add(i, new Stack<string>());
               
            }

            //TODO lisää stackkeihin laatikot
            //Formula: 1 + i * 4 tai skippaa ensimmäinen kirjain [

            return stacks;
        }

    }
}
