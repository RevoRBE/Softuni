using System;


namespace _19.OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0.0;
            string evenOrOdd = "";

            if (symbol == '+')
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, evenOrOdd);
                }
                else
                {
                    evenOrOdd = "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, evenOrOdd);
                }
            }
            else if (symbol == '-')
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, evenOrOdd);
                }
                else
                {
                    evenOrOdd = "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, evenOrOdd);
                }
            }
            else if (symbol == '*')
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, evenOrOdd);
                }
                else
                {
                    evenOrOdd = "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, evenOrOdd);
                }
            }

            if (symbol == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", num1, symbol, num2, result);
                }
            }
            else if (symbol == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, symbol, num2, result);
                }
            }
        }
    }
}
