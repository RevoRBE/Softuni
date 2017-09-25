using System;
using System.Linq;


namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrO = new int[n];
            int[] arrE = new int[n];

            for (int i = 0; i < n  ; i++)
            {
                if (i % 2 == 0)
                {
                    arrE[i] = int.Parse(Console.ReadLine());
                }
                else if (i % 2 == 1)
                {
                    arrO[i] = int.Parse(Console.ReadLine());
                }
            }

            if (arrE.Sum()==arrO.Sum())
            {
                Console.WriteLine("Yes Sum = {0}", arrO.Sum());
            }
            else
            {
                Console.WriteLine("No Diff= " + Math.Abs(arrO.Sum()-arrE.Sum()));
            }
        }
    }
}