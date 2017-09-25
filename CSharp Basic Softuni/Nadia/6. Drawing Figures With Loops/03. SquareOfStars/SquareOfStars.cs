using System;


namespace _03.SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //6

            for (int row = 1; row <= n; row++)
            {
                /*Console.Write("*");
                for (int col = 1; col < n; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();*/
                for (int ch = 0; ch < n - 1; ch++) //6-1=5
                {
                    Console.Write("* "); //5
                }
                Console.WriteLine("*"); //1 without space and go on a new row
            }
        }
    }
}
