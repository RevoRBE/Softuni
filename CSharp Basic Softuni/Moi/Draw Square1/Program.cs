using System;
class Square_of_Stars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n*2; i++)
        {
            Console.Write("*");
            if (i == n - 1)
            {
                Console.WriteLine();
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write("*");
                    for (int b = 0; b < n - 2; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
    }
}