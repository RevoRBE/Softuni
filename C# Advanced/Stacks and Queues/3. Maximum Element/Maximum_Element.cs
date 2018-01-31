using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

class Maximum_Element_Me
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            switch (input[0])
            {
                case 1:
                    var toPush = input[1];
                    stack.Push(toPush);
                    break;
                case 2:
                    if (stack.Count != 0) stack.Pop();
                    break;
                case 3:
                    if (stack.Count != 0) Console.WriteLine(stack.Max());
                    break;
            }
        }
    }
}