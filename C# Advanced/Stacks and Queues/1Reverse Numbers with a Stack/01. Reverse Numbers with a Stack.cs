using System;
using System.Collections;
using System.Linq;


class Program
{
    static void Main()
    {
        var toReverse = new Stack(Console.ReadLine().Split().Select(int.Parse).ToArray());
        while (toReverse.Count > 0)
        {
            if (toReverse.Count == 1)
            {
                Console.WriteLine(toReverse.Pop());
                return;
            }
            Console.Write(toReverse.Pop().ToString() + " ");
        }
    }
}
