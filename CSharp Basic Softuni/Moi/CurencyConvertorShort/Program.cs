using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class nestedSwitch
    {
        static void Main(string[] args)
        {
            double val = double.Parse(Console.ReadLine());
            string cur1 = Console.ReadLine();
            string cur2 = Console.ReadLine();
            double usd = 1.79549; double eur = 1.95583; double gbp = 2.53405;
            switch (cur1) //transforma all to bgn
            {
                case "BGN":
                    break;
                case "EUR":
                    val *= eur;
                    break;
                case "USD":
                    val *= usd;
                    break;
                case "GBP":
                    val *= gbp;
                    break;
            }
            switch (cur2) 
            {
                case "BGN":
                    break;
                case "EUR":
                    val /= eur;
                    break;
                case "USD":
                    val /= usd;
                    break;
                case "GBP":
                    val /= gbp;
                    break;
            }
            Console.WriteLine("{0:F2}", val);
        }
    }
}