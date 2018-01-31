using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var parameters = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray());
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var stack = new Queue<int>();
        parameters.Pop();

        for (int i = 0; i < array.Length; i++)
        {
            stack.Enqueue(array[i]);
        }

        for (int i = 0; i < parameters.Peek(); i++) stack.Dequeue();
        parameters.Pop();

        if (stack.Count > 0)
            if (stack.Contains(parameters.Pop())) Console.WriteLine("true");
            else Console.WriteLine(stack.Min());
        else Console.WriteLine(0);
    }
}

