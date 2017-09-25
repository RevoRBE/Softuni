using System;


namespace _04.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("Greater number: {0}", num1);
            }
            else
            {
                Console.WriteLine("Greater number: {0}", num2);
            }
        }
    }
}
