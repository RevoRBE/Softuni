using System;


namespace _20.MagicDigits
{
    class MagicDigits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 100000; i <= 999999; i++)
            {
                int firstDigit = i / 100000;
                int secondDigit = i /10000 % 10;
                int thirdDigit = i / 1000 % 10;
                int fourthDigit = i / 100 % 10;
                int fifthDigit = i / 10 % 10;
                int sixthDigit = i % 10;;

                int sum = firstDigit * secondDigit * thirdDigit * fourthDigit * fifthDigit * sixthDigit;

                if (sum == n)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
