﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            string[] town = new string[]{"sofia", "plovdiv", "varna"};
            string[] food = new string[]{"coffee", "water", "beer","sweets","peanuts"};
            string[,] shop = new string[,] {{"0.5", "0.8", "1.2", "1.45", "1.6" },{ "0.4", "0.7", "1.15", "1.3", "1.5"},{"0.45", "0.7", "1.1", "1.35","1.55"}};
            Console.WriteLine(quantity*double.Parse(shop[Array.IndexOf(town, city),Array.IndexOf(food,product)]));

            //if (city == "sofia")
            //{
            //    if (product == "coffee")
            //    {
            //        price = 0.5;
            //    }
            //    else if (product == "water")
            //    {
            //        price = 0.8;
            //    }
            //    else if (product == "beer")
            //    {
            //        price = 1.2;
            //    }
            //    else if (product == "sweets")
            //    {
            //        price = 1.45;
            //    }
            //    else if (product == "peanuts")
            //    {
            //        price = 1.6;
            //    }
            //}
            //else if (city == "plovdiv")
            //{
            //    if (product == "coffee")
            //    {
            //        price = 0.4;
            //    }
            //    else if (product == "water")
            //    {
            //        price = 0.7;
            //    }
            //    else if (product == "beer")
            //    {
            //        price = 1.15;
            //    }
            //    else if (product == "sweets")
            //    {
            //        price = 1.3;
            //    }
            //    else if (product == "peanuts")
            //    {
            //        price = 1.5;
            //    }
            //}
            //else if (city == "varna")
            //{
            //    if (product == "coffee")
            //    {
            //        price = 0.45;
            //    }
            //    else if (product == "water")
            //    {
            //        price = 0.7;
            //    }
            //    else if (product == "beer")
            //    {
            //        price = 1.1;
            //    }
            //    else if (product == "sweets")
            //    {
            //        price = 1.35;
            //    }
            //    else if (product == "peanuts")
            //    {
            //        price = 1.55;
            //    }
            //}
        }
    }
}
