using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        var searchedPerson = Console.ReadLine();
        var family = new List<Person>();
        CollectData(family);
        PrintParentsAndChildren(family, searchedPerson);
    }

    private static void PrintParentsAndChildren(List<Person> allPeople, string searchedPersonParam)
    {
        var person = allPeople.FirstOrDefault(p => (searchedPersonParam.Contains("/"))
            ? p.BirthDate == searchedPersonParam
            : p.Name == searchedPersonParam);

        var result = new StringBuilder();
        result.AppendLine($"{person.Name} {person.BirthDate}");

        result.AppendLine("Parents:");
        foreach (var parent in allPeople.Where(p => p.FindChildName(person.Name) != null))
        {
            result.AppendLine($"{parent.Name} {parent.BirthDate}");
        }

        result.AppendLine("Children:");
        foreach (var child in allPeople.FirstOrDefault(p => p.Name == person.Name).Children)
        {
            result.AppendLine($"{child.Name} {child.BirthDate}");
        }

        Console.WriteLine(result);
    }

    private static void CollectData(List<Person> allPeople)
    {
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            if (input.Contains("-")) linkChildren2Parent(allPeople, input);
            else addMissinInfo(allPeople, input);
        }
    }

    private static void addMissinInfo(List<Person> family, string input)
    {
        var tokens = input.Split(' ');
        var name = $"{tokens[0]} {tokens[1]}";
        var date = tokens[2];
        var added = false;

        for (int i = 0; i < family.Count; i++)
        {
            if (family[i].Name == name)
            {
                family[i].BirthDate = date;
                added = true;
            }

            if (family[i].BirthDate == date)
            {
                family[i].Name = name;
                added = true;
            }

            family[i].AddChildrenInfo(name, date);
        }

        if (!added)
        {
            family.Add(new Person(name, date));
        }
    }

    private static void linkChildren2Parent(List<Person> allPeople, string input)
    {
        var tokens = input
            .Split('-')
            .Select(x => x.Trim())
            .ToArray();

        var parentParam = tokens[0];
        var childParam = tokens[1];

        // Parent
        var parent = allPeople.FirstOrDefault(p => (parentParam.Contains("/")) //Find Parent by name or BD or return null
            ? p.BirthDate == parentParam
            : p.Name == parentParam);

        if (parent == null) //Create if not found
        {
            parent = (parentParam.Contains("/"))
                ? new Person { BirthDate = parentParam }
                : new Person { Name = parentParam };

            allPeople.Add(parent);
        }

        // Create child
        var child = (childParam.Contains("/"))
            ? new Person { BirthDate = childParam }
            : new Person { Name = childParam };

        parent.AddChild(child);
    }
}