using System;


namespace _14.NumberTable
{
    class NumberTable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int down = 0; down < n; down++)
            {
                for (int left = 0; left < n; left++)
                {
                    int currentNum = down + left + 1;

                    if (currentNum > n)
                    {
                        currentNum = n - currentNum % n; // 2 * n - currentNum
                    }
                    Console.Write(currentNum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
