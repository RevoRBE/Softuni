using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n)); //variant 1
            //varian 2
            //Console.WriteLine(string.Concat(Enumerable.Repeat("*", side)));
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', n - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", n)));
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", n)));

            StringBuilder str = new StringBuilder();
            str.Append('*').Append(' ', n - 2).Append('*');
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", n)));

        }
    }
}
