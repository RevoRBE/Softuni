using System;


namespace _04.EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = 1;

            //Console.WriteLine(result);

            //for (int i = 0; i < n / 2; i++)
            //{
            //    result *= 4;
            //    Console.WriteLine(result);
            //}

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(result);
                result *= 4;
            }
        }
    }
}
