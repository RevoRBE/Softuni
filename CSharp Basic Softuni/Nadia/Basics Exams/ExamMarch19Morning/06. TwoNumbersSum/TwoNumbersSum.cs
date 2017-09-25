using System;


namespace _06.TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main()
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int cnt = 0;

            for (int i = begin; i >= end; i--)
            {
                for (int j = begin; j >= end; j--)
                {
                    cnt++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{cnt} ({i}" + $" + {j} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{cnt} combinations " + $"- neither equals {magicNum}");
        }
    }
}
