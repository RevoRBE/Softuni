using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

class Maximum_Element
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> maxStack = new Stack<int>();
        var input = Console.ReadLine().Split("".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int i = 0; i < n; i++)
        {
            switch (input[0])
            {
                case 1:
                    var temp = input[1];
                    stack.Push(temp);
                    if (maxStack.Peek() <= temp) maxStack.Push(temp);
                    break;
                case 2:
                    var popedElement = stack.Pop();
                    if (popedElement == maxStack.Peek())
                        maxStack.Pop();
                    break;
                case 3:
                    Console.WriteLine(maxStack.Peek());
                    break;
            }
            input = Console.ReadLine().Split("".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}