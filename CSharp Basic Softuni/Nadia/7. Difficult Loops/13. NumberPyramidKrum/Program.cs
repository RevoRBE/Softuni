using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int inc = 1;
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j <= i && num >= inc; j++)
            {
                Console.Write("{0} ", inc++);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}