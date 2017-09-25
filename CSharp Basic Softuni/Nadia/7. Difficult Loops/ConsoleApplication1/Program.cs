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
        int n = int.Parse(Console.ReadLine());
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n ; j++)
            {
                num = i + j + 1;
                Console.Write("{0} ", i+j+1 <= n? i+j+1:2*n -num);   
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}