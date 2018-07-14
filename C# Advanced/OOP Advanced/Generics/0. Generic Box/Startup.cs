using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list = new List<Box<string>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            Box<string> stringBox = new Box<string>(input);

            list.Add(stringBox);
        }

        int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int firstIndex = indexes[0];
        int secondIndex = indexes[1];

        Swap(list, firstIndex, secondIndex);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static void Swap(List<Box<string>> list, int firstIndex, int secondIndex)
    {
        var temp = list[firstIndex];
        list[firstIndex] = list[secondIndex];
        list[secondIndex] = temp;
    }
}