using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MoneyPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int pp = int.Parse(Console.ReadLine());
            double levpp = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < pp; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                sum += i % 2 == 0 ? temp : temp * 2;
            }
            sum *= levpp;
            Console.WriteLine($"The project prize was {sum:F2} lv.");
        }
    }
}
