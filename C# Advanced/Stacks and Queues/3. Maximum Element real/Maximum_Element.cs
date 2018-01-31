using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximum_Element
{
    class Maximum_Element
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split("".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            var max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        //if (max < input[1]) max = input[1];
                        break;
                    case 2: stack.Pop(); break;
                    case 3: 
                        if (stack.Count !=0 )max= stack.Max(); 
                        Console.WriteLine(max); break;
                }

                //if (input[0] == "1") stack.Push(input[1]);
                //else if (input[0] == "2") stack.Pop();
                //else if (input[0] == "3") Console.WriteLine(stack.Max());
                input = Console.ReadLine().Split("".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
        }
    }
}
