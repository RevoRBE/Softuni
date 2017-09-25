using System;


namespace _09.SumDigits
{
    class SumDigits
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            do
            {
                sum += num % 10; //takes the last digit
                num = num / 10; // cut the last digit
            } while (num != 0);
            Console.WriteLine(sum);
        }
    }
}
