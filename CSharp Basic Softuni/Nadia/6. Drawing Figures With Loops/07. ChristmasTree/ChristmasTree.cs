using System;


namespace _07.ChristmasTree
{
    class ChristmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i) + new string('*', i) + " | " + new string('*', i)+ new string(' ', n - i));
                Console.WriteLine();
            }
        }
    }
}
