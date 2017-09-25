using System;


namespace _03.PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = 1; //2 ^ 0

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(result);
                result *= 2;
            }
            Console.WriteLine(result);
        }
    }
}
