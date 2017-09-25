using System;


namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int down = 1; down <= n; down++)
            {
                if (down == 1 || down == n)
                {
                    Console.Write("+");
                    for (int right = 1; right <= n - 2; right++)
                    {
                        Console.Write(" -");
                    }
                    Console.Write(" +");
                }
                else
                {
                    Console.Write("|");
                    for (int right = 1; right <= n - 2; right++)
                    {
                        Console.Write(" -");
                    }
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
    }
}
