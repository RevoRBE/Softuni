using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));
        }   

        public static long Fibonacci(int number)
        {
            if (number == 0) return 0;
            else if(number ==1) return 1;
            else return Fibonacci(number - 2) + Fibonacci(number - 1);
        }
        static long FibWithLoop(long n)
        {
            long f1 = 1;
            long f2 = 1;
            long f_result = 0;
 
            for (int i=2; i < n; i++)
            {
                f_result = f1 + f2;
                f1 = f2;
                f2 = f_result;
            }
 
            return f_result;
        }
    }
}
