using System;


namespace _07.NumberGenerator2
{
    class NumberGenerator2
    {
        static void Main()
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            var specialNum = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());

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
                            if (specialNum == controlNum)
                            {
                                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNum);
                            }
                            else
                            {
                                Console.WriteLine("No! {0} is the last reached special number.", specialNum);
                            }
                            return;
                        }
                        else if (num % 10 == 5)
                        {
                            specialNum -= 2;
                            if (specialNum == controlNum)
                            {
                                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNum);
                            }
                            else
                            {
                                Console.WriteLine("No! {0} is the last reached special number.", specialNum);
                            }
                            return;
                        }
                        else if (num % 2 == 0)
                        {
                            specialNum *= 2;
                            if (specialNum == controlNum)
                            {
                                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNum);
                            }
                            else
                            {
                                Console.WriteLine("No! {0} is the last reached special number.", specialNum);
                            }
                            return;
                        }
                        else if (specialNum >= controlNum)
                        {
                            return;
                        }
                        break;
                    }
                }
            }
        }
    }
}
