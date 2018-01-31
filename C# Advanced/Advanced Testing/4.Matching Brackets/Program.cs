using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var openBracketIndxs = new Stack<string>();
            for (int i = 0; i < 0; i++)
            {
                if (input[i] = '(') openBracketIndxs.Push(i);
                if (input[i] = ')')
                {
                    openBracketIndxs.Push(i);
                }
            }
        }
    }
}
