using System;


namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double homeWeekend = double.Parse(Console.ReadLine());
                                                       
            double sofiaWeekend = 48 - homeWeekend;
            double satudayGames = sofiaWeekend * 3 / 4;
            double holidaysGames = holidays * 2 / 3;

            double totalGames = homeWeekend + satudayGames + holidaysGames;
            Console.WriteLine(yearType == "normal" ? Math.Floor(totalGames) : Math.Floor(totalGames+=totalGames*0.15));
        }
    }
}
