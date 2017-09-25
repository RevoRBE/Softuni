using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string[] products = new string[] { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };
            string[] weekends = new string[] { "saturday", "sunday" };
            string[] weekDays = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday" };
            double[,] priceList = new double[,] { { 2.5, 1.2, 0.85, 1.45, 2.7, 5.5, 3.85 }, { 2.7, 1.25, 0.9, 1.6, 3.0, 5.6, 4.20 } };

            string product = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            bool validStock = products.Any(product.Contains);
            bool validDay = weekends.Any(day.Contains) || weekDays.Any(day.Contains);
            bool weekend = weekends.Any(day.Contains);
            bool validInput = validDay&&validStock;

            Console.WriteLine(validInput ? (quantity * priceList[!weekend ? 0 : 1, Array.IndexOf(products, product)]).ToString("F2") : "error");
            
            //Console.WriteLine(fruit.Any(input.Contains)?"fruit":vegetable.Any(input.Contains)?"vegetable":"unknown");
            //Dictionary<string, double> weekDayPrices = new Dictionar<string, double> { "banana" = 2.5, "apple" = 1.2, "orange" = 0.85, "grapefruit" = 1.45, "kiwi" = 2.7, "pineapple" = 5.5, "grapes" = 3.85 };
            //Dictionary<string, double> weekendPrices = new Dictionar<string, double> { "banana" = 2.7, "apple" = 1.25, "orange" = 0.9, "grapefruit" = 1.60, "kiwi" = 3.0, "pineapple" = 5.6, "grapes" = 4.20 };
            
            //if ("monday","tuesday","wednesday","thursday","friday")
            //{
            //    if (product == "banana")
            //    {
            //        price = 2.5;
            //    }
            //    else if (product == "apple")
            //    {
            //        price = 1.2;
            //    }
            //    else if (product == "orange")
            //    {
            //        price = 0.85;
            //    }
            //    else if (product == "grapefruit")
            //    {
            //        price = 1.45;
            //    }
            //    else if (product == "kiwi")
            //    {
            //        price = 2.7;
            //    }
            //    else if (product == "pineapple")
            //    {
            //        price = 5.5;
            //    }
            //    else if (product == "grapes")
            //    {
            //        price = 3.85;
            //    }
            //    else
            //    {
            //        validInput = false;
            //    }
            //}
            //else if (day == "saturday" || day == "sunday")
            //{
            //    if (product == "banana")
            //    {
            //        price = 2.7;
            //    }
            //    else if (product == "apple")
            //    {
            //        price = 1.25;
            //    }
            //    else if (product == "orange")
            //    {
            //        price = 0.90;
            //    }
            //    else if (product == "grapefruit")
            //    {
            //        price = 1.60;
            //    }
            //    else if (product == "kiwi")
            //    {
            //        price = 3;
            //    }
            //    else if (product == "pineapple")
            //    {
            //        price = 5.6;
            //    }
            //    else if (product == "grapes")
            //    {
            //        price = 4.20;
            //    }
            //    else
            //    {
            //        validInput = false;
            //    }            
            //}
            //else
            //{
            //    validInput = false;
            //}

            //if (validInput)
            //{
            //    Console.WriteLine("{0:f2}", quantity * price);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}
        }
    }
}
