using System;


namespace _03.SchoolCamp
{
    class SchoolCamp
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            string groupType = Console.ReadLine().ToLower();
            double numScoolers = double.Parse(Console.ReadLine());
            double numNights = double.Parse(Console.ReadLine());

            if (season == "winter" && groupType == "girls")
            {
                string sport = "Gymnastics";
                double priceNight = numScoolers * 9.60 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "winter" && groupType == "boys")
            {
                string sport = "Judo";
                double priceNight = numScoolers * 9.60 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "winter" && groupType == "mixed")
            {
                string sport = "Ski";
                double priceNight = numScoolers * 10 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "spring" && groupType == "girls")
            {
                string sport = "Athletics";
                double priceNight = numScoolers * 7.20 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "spring" && groupType == "boys")
            {
                string sport = "Tennis";
                double priceNight = numScoolers * 7.20 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "spring" && groupType == "mixed")
            {
                string sport = "Cycling";
                double priceNight = numScoolers * 9.50 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "summer" && groupType == "girls")
            {
                string sport = "Volleyball";
                double priceNight = numScoolers * 15 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "summer" && groupType == "boys")
            {
                string sport = "Football";
                double priceNight = numScoolers * 15 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
            else if (season == "summer" && groupType == "mixed")
            {
                string sport = "Swimming";
                double priceNight = numScoolers * 20 * numNights;
                if (numScoolers >= 0 && numScoolers < 10)
                {
                    Console.WriteLine("{0} {1:f2} lv.", sport, priceNight);
                }
                else if (numScoolers >= 10 && numScoolers < 20)
                {
                    double totalPrice = priceNight - (0.05 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 20 && numScoolers < 50)
                {
                    double totalPrice = priceNight - (0.15 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
                else if (numScoolers >= 50)
                {
                    double totalPrice = priceNight - (0.50 * priceNight);
                    Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
                }
            }
        }
    }
}
