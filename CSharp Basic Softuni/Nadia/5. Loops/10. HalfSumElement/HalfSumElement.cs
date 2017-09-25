using System;
using System.Collections.Generic;
using System.Linq;


namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            double sum = numbers.Sum();
            int max = numbers.Max();
            if (max == sum / 2)
            {
                Console.WriteLine("Yes Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(max - (sum - max)));
            }
        }
    }
}
