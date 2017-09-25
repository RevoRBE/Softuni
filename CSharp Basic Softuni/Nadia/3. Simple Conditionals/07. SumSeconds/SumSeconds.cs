using System;


namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int firstPalyer = int.Parse(Console.ReadLine());
            int secondPalyer = int.Parse(Console.ReadLine());
            int thirdPalyer = int.Parse(Console.ReadLine());

            int totalSeconds = firstPalyer + secondPalyer + thirdPalyer;

            //int seconds = totalSeconds % 60;
            //int minutes = totalSeconds / 60;

            int seconds = 0;
            int minutes = 0;

            if (totalSeconds < 60)
            {
                seconds = totalSeconds;
            }
            else if (totalSeconds < 120)
            {
                minutes = 1;
                seconds = totalSeconds - 60;
            }
            else if (totalSeconds < 180)
            {
                minutes = 2;
                seconds = totalSeconds - 120;
            }
            Console.WriteLine("{0}:{1:00}", minutes, seconds); //- 2:04 - s vodeshta 0
        }
    }
}
