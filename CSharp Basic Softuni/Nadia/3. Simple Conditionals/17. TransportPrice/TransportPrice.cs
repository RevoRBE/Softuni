using System;


namespace _17.TransportPrice
{
    class TransportPrice
    {
        static void Main()
        {
            int kilometers = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double rate = 0;

            double dayTaxi = 0.79;
            double nightTaxi = 0.90;
            double bus = 0.09;
            double train = 0.06;

            if (kilometers >= 0 && kilometers < 20)
            {
                if (time == "day")
                {
                    rate = 0.70 + (kilometers * dayTaxi);
                }
                else
                {
                    rate = 0.70 + (kilometers * nightTaxi);
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                rate = kilometers * bus;
            }
            else
            {
                rate = kilometers * train;
            }
            Console.WriteLine(Math.Round(rate, 2));
        }
    }
}
