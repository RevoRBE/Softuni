using System;


namespace _06.NumberGenerator
{
    class NumberGenerator
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        int num = i * 100 + j * 10 + k;

                        if (num % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (num % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (num % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= controlNum)
                        {
                            break;
                        }                     
                    }
                    if (specialNum >= controlNum)
                    {
                        break;
                    }
                }
                if (specialNum >= controlNum)
                {
                    break;
                }
            }
            if (specialNum == controlNum || specialNum > controlNum)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNum);
            }
            else
            {
                Console.WriteLine("No! {0} is the last reached special number.", specialNum);
            }
        }
    }
}
