using System;


namespace _06.LettersCombinations
{
    class LettersCombinations
    {
        static void Main()
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char magicChar = char.Parse(Console.ReadLine());

            int cnt = 0;

            for (char i = begin; i <= end; i++)
            {
                for (char j = begin; j <= end; j++)
                {
                    for (char k = begin; k <= end; k++)
                    {
                        if (i != magicChar && j != magicChar && k != magicChar)
                        {
                            Console.Write($"{i}{j}{k} ");
                            cnt++;
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
