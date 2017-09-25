using System;

namespace _05.SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int dots = 6 * n - 3;

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots - 3 * i), new string('#', 1 + 6 * i));
            }

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string('.', 2 + 3 * i) + new string('#', 12 * n - 11 - 6 * i) + new string('.', 3 + 3 * i));
            }
          
            char symbol = '|';
                      
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    symbol = '@';
                }
                Console.WriteLine(symbol + new string('.', n * 3 - 4) + new string('#', 6 * n + 1) + new string('.', n * 3 - 3));
            }
            //Console.WriteLine("@{0}{1}#{1}{2}", new string('.', 2 * n - 1), new string('#', 3 * n), new string('.', 2 * n));
            //Console.WriteLine("@{0}{1}#{1}{2}", new string('.', 2 * n - 1), new string('#', 3 * n), new string('.', 2 * n));
        }
    }
}
