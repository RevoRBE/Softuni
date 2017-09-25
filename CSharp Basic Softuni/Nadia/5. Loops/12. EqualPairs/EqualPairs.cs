using System;


namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            int sum = 0;
            int prevSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 0; i < length; i++)
            {
                int firNum = int.Parse(Console.ReadLine());
                int SecNum = int.Parse(Console.ReadLine());
                sum = firNum + SecNum;
                if (i != 0)
                {
                    diff = Math.Abs(sum - prevSum);
                }
                if (sum > prevSum || sum < prevSum)
                {
                    prevSum = sum;
                }
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
            if (diff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
