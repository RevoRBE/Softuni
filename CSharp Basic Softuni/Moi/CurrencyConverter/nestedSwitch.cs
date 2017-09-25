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
            double usd = 1.79549;   double eur = 1.95583;   double gbp = 2.53405;   double result = 0;
            switch (cur1)
            {
                case "BGN":
                    switch (cur2)
                    {
                        case "USD":
                            result =val/usd;                                                         
                            break;                                                                       
                        case "EUR":
                            result =val/eur;
                            break;
                        case "GBP":
                            result = val/gbp;
                            break;
                    }
                    break;
                case "EUR":
                    switch (cur2)
	                {
                        case "USD":
                            result = val*eur/usd;
                            break;
                        case "GBP":
                            result = val*eur/gbp;
                            break;
                        case "BGN":
                            result =val*eur;
                            break;
    	            }
                    break;
                case "USD":
                    switch (cur2)
	                {
                        case "GBP":
                            result =val*usd/gbp;
                            break;
                        case "BGN":
                            result =val*usd;
                            break;
                        case "EUR":
                            result =val*usd/eur;
                            break;
	                }
                    break;
                case "GBP":
                    switch (cur2)
	                {
                        case "BGN":
                            result =val*gbp;
                            break;
                        case "USD":
                            result =val*gbp/usd;
                            break;
                        case "EUR":
                            result =val*gbp/eur;
                            break;
	                }
                    break;
                }
            Console.WriteLine("{0:F2}", result);    
            }
        }
    }