using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.HouseKrum
{
    class Program
    {
        static void Main(string[] args)
        {
            //6           5
            //--**--      --*--
            //-****-      -***-
            //******      *****
            //|****|      |***|
            //|****|      |***|
            //|****|
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (((n - 1) / 2) - i)), new string('*', i * 2 + (n % 2 == 0 ? 2 : 1)));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("|{0}|", new string('*',n-2));
            }
        }
    }
}
