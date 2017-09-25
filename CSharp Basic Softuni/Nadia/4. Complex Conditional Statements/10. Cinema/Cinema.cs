using System;


namespace _10.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string projectionType = Console.ReadLine().ToLower;
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int seats = rows * cols;

            double result = 0;

            if (projectionType == "premiere") result = seats * 12.00;
            else if (projectionType == "normal") result = seats * 7.50;
            else if (projectionType == "discount") result = seats * 5.00;
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
