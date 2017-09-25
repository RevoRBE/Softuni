using System;


namespace _04.Bills
{
    class Bills
    {
        static void Main()
        {
            int months = int.Parse(Console.ReadLine());

            double water = 20 * months;
            double internet = 15 * months;
            double electricityTotal = 0;

            for (int i = 0; i < months; i++)
            {
                double electriciry = double.Parse(Console.ReadLine());
                electricityTotal += electriciry;
            }
            double others = (water + internet + electricityTotal) * 1.20; // 100% +20% = 1.20
            double average = (water + internet + others + electricityTotal) / months;

            Console.WriteLine("Electricity: {0:f2} lv", electricityTotal);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", others);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}
