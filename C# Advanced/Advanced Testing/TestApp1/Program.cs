using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var elements = input.Split();
            var stack = new Stack<string>();
            for (int i = elements.Length - 1; i >= 0; i--)
                stack.Push(elements[i]);

            while (stack.Count > 1)
            {
                var leftOperand = int.Parse(stack.Pop());
                var calcOperator = stack.Pop();
                var rightOperand = int.Parse(stack.Pop());
                switch (calcOperator)
                {
                    case "-":
                        stack.Push((leftOperand - rightOperand).ToString());
                        break;
                    default:
                        stack.Push((leftOperand + rightOperand).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
