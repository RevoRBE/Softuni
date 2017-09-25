using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SunglassesKrum
{
    class Program
    {
        static void Main(string[] args)
        {
            //******   ******
            //*////*|||*////*3
            //******   ******
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
                }
                else if (i == (n-1) / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string('|', n));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
                }
            }
        }
    }
}
