using System;


namespace _04.TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            /*for (int row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }*/
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$");
            }           
        }
    }
}
