using System;


namespace _18.Trip
{
    class Trip
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string destination = "";
            string holydayType = "";
            double spentMoney = 0.0;

            if (season == "summer")
            {
                holydayType = "Camp";
            }
            else if(season == "winter")
            {
                holydayType = "Hotel";
            }

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spentMoney = budget * 0.3;
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spentMoney = budget * 0.4;
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    holydayType = "Hotel";
                    spentMoney = budget * 0.9;
                }
            }
            Console.WriteLine("Somewhere in {0} \n{1} - {2:f2}", destination, holydayType, spentMoney);
        }
    }
}
