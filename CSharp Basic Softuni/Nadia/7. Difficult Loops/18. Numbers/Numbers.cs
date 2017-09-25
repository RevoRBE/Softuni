using System;


namespace _18.Numbers
{
    class Numbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 100;
            int secondDigit = n / 10 % 10;
            int thirdDigit = n % 10;

            for (int down = 0; down < firstDigit + secondDigit; down++)
            {
                for (int left = 0; left < firstDigit + thirdDigit; left++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                    }
                    else
                    {
                        n += thirdDigit;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
