using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DiamondKrum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2) { Console.WriteLine(n == 1 ? "*" : "**"); return; }
            if (n % 2 != 0)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n / 2 - 1 - i)), new string('-', 1 + i * 2));
                }
                for (int i = n / 2 - 2; i >= 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2 - 1 - i), new string('-', 1 + i * 2));
                }
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));

            }
            if (n % 2 == 0)
            {
                for (int i = 0; i <= (n / 2) - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - 1) / 2 - i)), new string('-', i * 2));
                }
                for (int i = n / 2-2; i >= 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - 1) / 2 - i)), new string('-', i * 2));
                }

            }
            Console.ReadLine();

        }
    }
}
