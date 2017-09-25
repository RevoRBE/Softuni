using System;


namespace _09.House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            int dashes = n / 2;
            int rows = n / 2 + 1;
            if (n % 2 == 0)
            {
                stars++;
                dashes--;
                rows--;
            }

            for (int i = 0; i < rows; i++)
            { // Draw the roof
                Console.Write(new string ('-', dashes - i));
                Console.Write(new string('*', stars + 2 * i));
                Console.WriteLine(new string('-', dashes - i));
            }
            for (int i = 0; i < n / 2; i++)
            { // Draw the house body: 
                Console.WriteLine("|" + new string('*', n - 2) + "|"); 
            }
        }
    }
}
