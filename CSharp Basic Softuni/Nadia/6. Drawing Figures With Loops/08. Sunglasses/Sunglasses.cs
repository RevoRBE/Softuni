using System;


namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int middleRowNum = n / 2;
            if (n % 2 == 0)
            {
                middleRowNum--;
            }

            //First Line
            Console.WriteLine(
                new string('*', 2 * n)
                + new string(' ', n)
                + new string('*', 2 * n));

            char special = ' ';

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == middleRowNum)
                {
                    special = '|';
                }
                Console.Write("*" + new string('/', 2 * n - 2) + "*");
                Console.Write(new string(special, n));
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                special = ' ';
            }

            //Last Line
            Console.WriteLine(
                new string('*', 2 * n)
                + new string(' ', n)
                + new string('*', 2 * n));
        }
    }
}
