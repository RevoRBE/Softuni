using System;


namespace _01.Test
{
    class Program
    {
        static void Main()
        {
            double priceWiskey = double.Parse(Console.ReadLine());
            double littersBeer = double.Parse(Console.ReadLine());
            double littersWine = double.Parse(Console.ReadLine());
            double littersRakia = double.Parse(Console.ReadLine());
            double littersWiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWiskey / 2;
            double priceWine = priceRakia - (0.4 * priceRakia);
            double priceBeer = priceRakia - (0.8 * priceRakia);

            double sumRakia = littersRakia * priceRakia;
            double sumWine = littersWine * priceWine;
            double sumBeer = littersBeer * priceBeer;
            double sumWiskey = littersWiskey * priceWiskey;

            double totalSum = sumRakia + sumWine + sumBeer + sumWiskey;

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
