﻿using System;


namespace _03.EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
