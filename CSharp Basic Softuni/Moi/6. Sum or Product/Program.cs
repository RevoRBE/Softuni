using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sum_or_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool nfound = true;
            for (int a = 1; a < 31; a++)
            {
                for (int b = 1; b < 31; b++)
                {
                    for (int c = 1; c < 31; c++)
                    {
                        if (a + b + c == n&&a<b&&b<c)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            nfound = false;
                        }
                        if (a * b * c == n && a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            nfound = false;
                        }
                    }
                }
            }
            if (nfound)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
