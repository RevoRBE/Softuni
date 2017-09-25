using System;


namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int f0 = 1; //f1
            int f1 = 1; //f0 + f1

            for (int f = 0; f < num-1; f++)
            {
                int temp = f1;
                f1 = f1 + f0;
                f0 = temp;            
            }
            Console.WriteLine(f1);
        }
    }
}
