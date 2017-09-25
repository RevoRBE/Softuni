using System;


namespace _02.Styrofoam
{
    class Styrofoam
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            int windowsCont = int.Parse(Console.ReadLine());
            double squareMetersPerPackage = double.Parse(Console.ReadLine());
            double packagePrice = double.Parse(Console.ReadLine());

            double areaWindows = windowsCont * 2.4;
            double areaWithotWindows = (area - areaWindows) * 1.1; //1.1 = 100 % + 10%

            double packageCount = Math.Ceiling(areaWithotWindows / squareMetersPerPackage);
            double moneyNeeded = packageCount * packagePrice;

            double diff = budget - moneyNeeded;

            if (diff < 0)
            {
                Console.WriteLine("Need more: {0:f2}", Math.Abs(diff));
            }
            else
            {
                Console.WriteLine("Spent: {0:f2}", moneyNeeded);
                Console.WriteLine("Left: {0:f2}", diff);
            }
        }
    }
}
