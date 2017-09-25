using System;


namespace _13.NumberPyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int down = 1; down <= n; down++)
            {
                for (int left = 1; left <= down; left++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n)
                    {
                        Console.WriteLine(); // new row
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
