using System;


namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(1); // !0 = 1
            }

            int fact = 1; // use BigInteger

            do // has one literation
            {
                fact *= num;
                num--;
            } while (num > 1);
            Console.WriteLine(fact);
        }
    }
}
