using System;

class AreaOfFigures
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double result = 0;

        if (figure == "square")
        {
            double num = double.Parse(Console.ReadLine());
            result = Math.Pow(num, 2);
        }
        else if (figure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            result = a * b;
        }
        else if (figure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            result = Math.PI * Math.Pow(r, 2);
        }
        else if (figure == "triangle")
        {
            double c = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            result = (c * h) / 2;
        }
        Console.WriteLine(Math.Round(result, 3));
    }
}