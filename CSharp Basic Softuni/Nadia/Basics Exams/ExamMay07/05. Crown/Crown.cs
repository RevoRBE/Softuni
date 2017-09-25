using System;


namespace _05.Crown
{
    class Crown
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@", new string(' ', (2 * n - 3) / 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', (2 * n - 5) / 2));

            for (int i = 0; i <= n / 2 - 3; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i + 1),
                    new string(' ', (2 * n - 9) / 2 - 2 * i),
                    new string('.', 2 * i + 1));
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n / 2 - 1)),
                new string ('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', (n / 2)),
                new string('*', n / 2 - 2));
            Console.WriteLine("{0}", new string('*', (2 * n) - 1));
            Console.WriteLine("{0}", new string('*', (2 * n) - 1));
        }
    }
}
