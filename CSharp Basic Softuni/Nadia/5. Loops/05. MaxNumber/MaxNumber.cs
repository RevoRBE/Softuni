using System;
using System.Linq;

class MaxNumber
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] masiv = new int[length];
        for (int i = 0; i < length; i++)
        {
            masiv[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(masiv.Min());
    }
}