using System;

class Program
{
    static void Main(string[] args)
    {
        int c1 = int.Parse(Console.ReadLine());
        int c2 = int.Parse(Console.ReadLine());
        int c5 = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());

        for (int a = 0; a <= c1; a++)
        {
            for (int b = 0; b <= c2; b++)
            {
                for (int c = 0; c <= c5; c++)
                {
                    if (a * 1 + b * 2 + c * 5 == sum)
                    {
                        Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}