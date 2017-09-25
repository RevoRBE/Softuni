using System;


namespace _01.GrapesAndSpiritWater
{
    class Program
    {
        static void Main()
        {
            double area = double.Parse(Console.ReadLine());
            double kiloParSquareMeter = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double kiloResult = area * kiloParSquareMeter;
            double kiloWithoutWait = kiloResult - waste;
            double grapeForRakia = kiloWithoutWait * 0.45;
            double grapeForSale = kiloWithoutWait * 0.55;
            double rakia = grapeForRakia / 7.5;
            double rakiaMoney = rakia * 9.8;
            double salesMoney = grapeForSale * 1.5;

            Console.WriteLine("{0:f2}", rakiaMoney);
            Console.WriteLine("{0:f2}", salesMoney);
        }
    }
}
