using System;


namespace _03.TruckDriver
{
    class TruckDriver
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            double kilometerParMonth = double.Parse(Console.ReadLine());

            double result = 0;

            switch (season)
            {
                case "spring":
                case "autumn":
                    if (kilometerParMonth <= 5000)
                    {
                        result = 0.75;
                    }
                    else if (kilometerParMonth <= 10000)
                    {
                        result = 0.95;
                    }
                    else
                    {
                        result = 1.45;
                    }
                    break;
                case "summer":
                    if (kilometerParMonth <= 5000)
                    {
                        result = 0.90;
                    }
                    else if (kilometerParMonth <= 10000)
                    {
                        result = 1.10;
                    }
                    else
                    {
                        result = 1.45;
                    }
                    break;
                case "winter":
                    if (kilometerParMonth <= 5000)
                    {
                        result = 1.05;
                    }
                    else if (kilometerParMonth <= 10000)
                    {
                        result = 1.25;
                    }
                    else
                    {
                        result = 1.45;
                    }
                    break;
            }
            //result = result * 4 - result * 0.4; // result * 0.1 
            //result *= 3.6;
            double moneyForSeason = result * kilometerParMonth * 4;
            moneyForSeason = moneyForSeason - moneyForSeason * 0.1;
            Console.WriteLine("{0:f2}", moneyForSeason);
        }
    }
}
