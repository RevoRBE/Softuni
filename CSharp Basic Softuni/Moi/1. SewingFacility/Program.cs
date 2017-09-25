using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double size1 = n * (d + 2 * 0.30) * (s + 2 * 0.30);
        double size2 = n * (d / 2) * (d / 2);
        double pu = size1 * 7 + size2 * 9;
        double pb = pu * 1.85;
        Console.WriteLine($"{pu:F2} USD");
        Console.WriteLine($"{pb:F2} BGN");
    }
}