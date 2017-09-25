using System;

namespace _19.SpecialDigits
{
    class SpecialDigits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 9999; i++)
            {
                int firstDigit = i / 1000;
                int secondDigit = i / 100 % 10;
                int thirdDigit = i / 10 % 10;
                int forthDigit = i % 10;

                if (firstDigit != 0 && secondDigit != 0 && thirdDigit != 0 && forthDigit != 0)
                {
                    if ((n % firstDigit == 0) && (n % secondDigit == 0) &&
                    (n % thirdDigit == 0) && (n % forthDigit == 0))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
