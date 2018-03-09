using System;
using System.Runtime.ConstrainedExecution;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            var person = new Person(tokens[0], int.Parse(tokens[1]));
            family.AddMember(person);
        }

        var ordered = family.task();
        foreach (var person in ordered)
        {
        Console.WriteLine(person);
        }
    }
}