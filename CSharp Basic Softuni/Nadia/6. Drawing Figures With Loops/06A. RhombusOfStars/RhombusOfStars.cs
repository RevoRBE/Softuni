using System;


namespace _06A.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //4

            //upper part
            for (int down = 0; down < n; down++)
            {
                Console.Write(new string(' ', n - 1 - down) + "*"); //3
                for (int rigth = 0; rigth < down; rigth++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            /*lower part
            for (int down = 0; down < n - 1; down++)
            {
                Console.Write(new string(' ', down + 1) + "*");
                for (int right = 0; right < n - 2 - down; right++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }*/
            for (int down = n - 1; down > 0; down--) //down = 3
            {
                Console.Write(new string(' ', n - down) + "*"); //1
                for (int right = down - 1; right > 0; right--) // right = 2
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
