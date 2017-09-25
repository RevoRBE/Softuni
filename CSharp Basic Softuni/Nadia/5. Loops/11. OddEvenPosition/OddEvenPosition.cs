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
            if (n == 0)
            {
                Console.WriteLine("OddSum=0, \nOddMin=No, \nOddMax=No, \nEvenSum=0, \nEvenMin=No, \nEvenMax=No");
                return;
            }
            else if (n==1)
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0}, \nOddMin={0}, \nOddMax={0}, \nEvenSum=0, \nEvenMin=No, \nEvenMax=No", num);
                return;
            }
            double[] input = new double[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }
            double[] odd = input.Where((nums, index) => index % 2 == 0).ToArray();
            double[] even = input.Where((nums, index) => index % 2 != 0).ToArray();
            double sumE = even.Sum(); double minE = even.Min(); double maxE = even.Max();
            double sumO = odd.Sum(); double minO = odd.Min(); double maxO = odd.Max();
            Console.WriteLine("OddSum={0}, \nOddMin={1}, \nOddMax={2}, \nEvenSum={3}, \nEvenMin={4}, \nEvenMax={5}", sumO, minO, maxO, sumE, minE, maxE);
        }
    }
}
