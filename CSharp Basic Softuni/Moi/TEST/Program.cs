using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        string health = '|' + new string('|', num1)+ new string('.', num2-num1)+'|';
        string energy = '|' + new string('|', num3) + new string('.', num4 - num3)+'|';
        Console.WriteLine($"Name: {name}\nHealth: {health}\nEnergy: {energy}");
    }
}