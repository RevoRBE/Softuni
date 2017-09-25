using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.forforforforforcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            string w = Console.ReadLine();
            string e = Console.ReadLine();
            string r = Console.ReadLine();
            char a = q[0];
            char b = w[0];
            char c = e[0];
            char d = r[0];
                 
            int cif = int.Parse(Console.ReadLine());
            int counter = -1;

            for (int i = 'A'; i <= a; i++)
            {
                for (int j = 'a'; j <= b; j++)
                {
                    for (int k = 'a'; k <= c; k++)
                    {
                        for (int m = 'a'; m <= d; m++)
                        {
                            for (int n = 0; n <= cif; n++)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
