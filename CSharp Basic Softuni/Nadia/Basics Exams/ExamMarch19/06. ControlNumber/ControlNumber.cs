using System;


namespace _06.ControlNumber
{
    class ControlNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlDigit = int.Parse(Console.ReadLine());

            int sum = 0;
            int cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += i * 2 + j * 3;
                    cnt++;
                    if (sum >= controlDigit)
                    {
                        Console.WriteLine(cnt + " moves");
                        Console.WriteLine($"Score: {sum} >= {controlDigit}");
                        return;
                    }
                }
            }
            Console.WriteLine(cnt + " moves");
        }
    }
}
