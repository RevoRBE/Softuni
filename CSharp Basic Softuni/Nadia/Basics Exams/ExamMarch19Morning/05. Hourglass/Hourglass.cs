using System;


namespace _05.Hourglass
{
    class Hourglass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(".*{0}*.", new string(' ', 2 * n - 3));

            for (int i = 1; i <= n - 2; i++)
            { 
                Console.WriteLine("{0}*{1}*{0}", new string ('.', i + 1), new string('@', 2 * n - 3 - 2 * i));
            }
            Console.WriteLine("{0}*{0}", new string('.', n));
            for (int i = 0; i < n - 2 ; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n - 1 - i),
                    new string(' ', i));
            }
            Console.WriteLine(".*{0}*.", new string('@', 2 * n - 3));
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
