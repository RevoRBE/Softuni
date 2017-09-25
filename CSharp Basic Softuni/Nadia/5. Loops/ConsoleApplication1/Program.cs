using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class OddEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] pairs = new int[n];
            int[] nums = new int[n * 2];
            for (int i = 0; i < n * 2; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                pairs[i] = nums[j] + nums[j + 1];
                j += 2;
            }
            int maxDiff = 0;
            int diff = 0;
            for (int i = 1; i < n; i++)
            {
                if (pairs[i] > pairs[i - 1] || pairs[i] < pairs[i - 1])
                {
                    diff = Math.Abs(pairs[i] - pairs[i - 1]);
                    if (diff > maxDiff) maxDiff = diff;
                }
            }
            Console.WriteLine(maxDiff == 0 ? "Yes, value={0}" : "No maxdiff={1}", pairs[0], maxDiff);
        }
    }
}