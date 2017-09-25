using System;


namespace _15.Harvest
{
    class Harvest
    {
        static void Main()
        {
            double vineyardSqM = double.Parse(Console.ReadLine());
            double grapesSqM = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double employees = double.Parse(Console.ReadLine());

            double totalGrapes = vineyardSqM * grapesSqM;
            double wine = totalGrapes * 0.4 / 2.5;

            if (wine >= wineLiters)
            {
                double restLiters = Math.Ceiling(wine - wineLiters);
                double litersPerPerson = Math.Ceiling(restLiters / employees);

                Console.WriteLine("Good harvest this year! Total wine: {0} liters. \n{1} liters left -> {2} liters per person.", Math.Floor(wine), restLiters, litersPerPerson);
            }
            else
            {
                double lackLiters = Math.Floor(wineLiters - wine);

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", lackLiters);
            }
        }
    }
}
