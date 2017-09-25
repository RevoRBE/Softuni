using System;


namespace _02.NtoOne
{
    class NtoOne
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--) //i-=3 - via 3 nums
            {
                Console.WriteLine(i);
            }

            /*for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(n - i);
            }*/
        }
    }
}
