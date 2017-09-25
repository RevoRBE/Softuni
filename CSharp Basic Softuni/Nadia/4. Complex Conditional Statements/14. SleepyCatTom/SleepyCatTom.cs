using System;


namespace _14.SleepyCatTom
{
    class SleepyCatTom
    {
        static void Main()
        {
            int dayOff = int.Parse(Console.ReadLine());

            int workDays = 365 - dayOff;
            int offMin = dayOff * 127;
            int workMin = workDays * 63;
            int playMin = offMin + workMin;

            if (playMin < 30000)
            {
                int restMin = 30000 - playMin;
                int hours = restMin / 60;
                int min = restMin % 60;

                Console.WriteLine("Tom sleeps well \n{0} hours and {1} minutes less for play", hours, min);
            }
            else
            {
                int moreMin = playMin - 30000;
                int hours = moreMin / 60;
                int min = moreMin % 60;

                Console.WriteLine("Tom will run away \n{0} hours and {1} minutes more for play", hours, min);
            }
        }
    }
}
