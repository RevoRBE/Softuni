using System;


namespace _06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //4

            for (int down = 1; down <= n; down++)
            {
                Console.Write(new string(' ', n - down) + "*");
                for (int right = 0; right < down - 1; right++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int down = n - 1; down > 0; down--) // n-1 (4-1=3) - without the middle row ****
            {
                Console.Write(new string(' ', n - down) + "*");
                for (int right = down - 1; right > 0; right--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
