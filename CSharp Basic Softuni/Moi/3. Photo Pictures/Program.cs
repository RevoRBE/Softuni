using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();
        string online = Console.ReadLine();
        double price = 0;
        switch (format)
        {
            case "9X13":
                price = num * 0.16;
                if (num >= 50) price *= 0.95;
                break;
            case "10X15":
                price = num * 0.16;
                if (num >= 80) price *= 0.97;
                break;
            case "13X18":
                price = num * 0.38;
                if (num >= 50 && num <= 100) price *= 0.97;
                else if (num > 100) price *= 0.95;
                break;
            case "20X30":
                price = num * 2.90;
                if (num >= 10 && num <= 50) price *= 0.93;
                else if (num > 50) price *= 0.91;
                break;
        }
        if (online == "online") price *= 0.98;
        Console.WriteLine("{0:F2}BGN", price);
    }
}