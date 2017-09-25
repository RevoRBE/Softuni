using System;


namespace _15.StupidPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int s1 = 1; s1 <= n; s1++)
            {
                for (int s2 = 1; s2 <= n; s2++)
                {
                    for (char s3 = 'a'; s3 < 'a' + l; s3++)
                    {
                        for (char s4 = 'a'; s4 < 'a' + l; s4++)
                        {
                            for (int s5 = Math.Max(s1, s2) + 1; s5 <= n; s5++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", s1, s2, s3, s4, s5);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
