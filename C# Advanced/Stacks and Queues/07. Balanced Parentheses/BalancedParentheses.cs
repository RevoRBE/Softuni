using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BalancedParentheses
{
    static void Main(string[] args)
    {
        char[] input = Console.ReadLine().ToCharArray();
        if (input.Length % 2 != 0)
        {
            Console.WriteLine("NO");
            Environment.Exit(0);
        }
        char[] opening = new[] { '{', '(', '[' };
        char[] closing = new[] { '}', ')', ']' };
        var checkStack = new Stack<char>();
        foreach (var bracket in input)
        {
            if (opening.Contains(bracket)) checkStack.Push(bracket);
            else if (closing.Contains(bracket))
            {
                var lastBracket = checkStack.Pop();
                int openingIndex = Array.IndexOf(opening, lastBracket);
                int closingIndex = Array.IndexOf(closing, bracket);
                if (openingIndex != closingIndex)
                {
                    Console.WriteLine("NO");
                    Environment.Exit(0);
                }
            }
        }
        if (checkStack.Any()) Console.WriteLine("NO");
        else Console.WriteLine("YES");
    }

}