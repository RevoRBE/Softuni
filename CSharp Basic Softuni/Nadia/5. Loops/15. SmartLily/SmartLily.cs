using System;

namespace _15.SmartLily
{
    class SmartLily
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int toy = 0;
            int money = 0;
            int safeToys = 0;
            int totalMoney = 0;
            int counter = 0;                     
            int bonus = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    toy++;
                }
                else if (i % 2 == 0)
                {
                    bonus += 10;
                    if (i == 2)
                    {
                        money = 10;
                    }
                    else
                    {
                        money += bonus;
                    }
                    money--;                       
                }
            }
            safeToys = priceToy * toy;
            totalMoney = safeToys + money;

            if (totalMoney >= priceLaundry)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - priceLaundry);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceLaundry - totalMoney);
            }
        }
    }
}
