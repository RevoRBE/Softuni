using System;


namespace _02.ToyShop
{
    class ToyShop
    {
        static void Main()
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            double numPuzzels = double.Parse(Console.ReadLine());
            double numDolls = double.Parse(Console.ReadLine());
            double numBears = double.Parse(Console.ReadLine());
            double numMinions = double.Parse(Console.ReadLine());
            double numTruks = double.Parse(Console.ReadLine());

            double sumPuzzels = numPuzzels * 2.60;
            double sumDolls = numDolls * 3;
            double sumBears = numBears * 4.10;
            double sumMinions = numMinions * 8.20;
            double sumTruks = numTruks * 2;

            double totalSum = sumPuzzels + sumDolls + sumBears + sumMinions + sumTruks;
            double totalToys = numPuzzels + numDolls + numBears + numMinions + numTruks;

            if (totalToys >= 50)
            {
                double discountedPrice = totalSum - (0.25 * totalSum);
                double rent = 0.1 * discountedPrice;
                double profit = discountedPrice - rent;
                if (profit >= priceExcursion)
                {
                    double leftMoney = profit - priceExcursion;
                    Console.WriteLine("Yes! {0:f2} lv left.", leftMoney);
                }
                else
                {
                    double neededMoney = priceExcursion - profit;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", neededMoney);
                }
            }
            else
            {
                double rent = 0.1 * totalSum;
                double profit = totalSum - rent;
                if (profit < priceExcursion)
                {
                    double neededMoney = priceExcursion - profit;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", neededMoney);
                }
                else
                {
                    double leftMoney = profit - priceExcursion;
                    Console.WriteLine("Yes! {0:f2} lv left.", leftMoney);
                }
            }
        }
    }
}
