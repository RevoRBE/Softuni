using System;


namespace _04.FootballLeague
{
    class FootballLeague
    {
        static void Main()
        {
            double stadium = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());

            double perA = 0.0;
            double perB = 0.0;
            double perV = 0.0;
            double perG = 0.0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine().ToUpper();

                if (sector == "A")
                {
                    perA++;
                }
                else if (sector == "B")
                {
                    perB++;
                }
                else if (sector == "V")
                {
                    perV++;
                }
                else if (sector == "G")
                {
                    perG++;
                }                
            }
            double perFans = perA + perB + perV + perG;
            
            Console.WriteLine("{0:f2}%", perA / fans * 100);
            Console.WriteLine("{0:f2}%", perB / fans * 100);
            Console.WriteLine("{0:f2}%", perV / fans * 100);
            Console.WriteLine("{0:f2}%", perG / fans * 100);
            Console.WriteLine("{0:f2}%", perFans / stadium * 100);
        }
    }
}
