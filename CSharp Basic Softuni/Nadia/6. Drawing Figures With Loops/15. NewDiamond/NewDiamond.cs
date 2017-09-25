using System;


namespace _15.NewDiamond
{
    class NewDiamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
            
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i), new string('.', 3 * n + 2 * i));
            }
            Console.WriteLine(new string('*', 5 * n));
            for (int i = 1; i < 3 * n + 1 - n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5 * n - 2 * i - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', (5 * n - n + 2) / 2), new string('*', n - 2));
        }
    }
}
