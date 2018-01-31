using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var matrix = new string[dimensions[0], dimensions[1]];
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}{1}{0} ", alphabet[i], alphabet[j + i]);
            }
            Console.WriteLine();
        }
    }
}