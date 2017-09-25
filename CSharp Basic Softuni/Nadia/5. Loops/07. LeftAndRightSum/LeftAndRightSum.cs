using System;
using System.Linq;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[]arrL = new int[n];
            int[]arrR = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrL[i] = int.Parse(Console.ReadLine());
            } 
            for (int i = 0; i < n; i++)
            {
                arrR[i] = int.Parse(Console.ReadLine());
            }

            if (arrL.Sum() == arrR.Sum())
            {
                Console.WriteLine("Yes, sum = {0}", arrL.Sum());
            }
            else
            {
                Console.WriteLine("No, diff= " + Math.Abs(arrL.Sum() - arrR.Sum()));
            }
        }
    }
}
