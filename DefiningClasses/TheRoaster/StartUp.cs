using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static List<Department> departaments;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        departaments = new List<Department>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split().ToArray();
            string depName = tokens[3];
            Employee currentEmployee = EmployeeParse(tokens);
            AddToDepartament(currentEmployee, depName);
        }

        var department = departaments.OrderByDescending(d => d.AverageSalary).First();
        Console.WriteLine($"Highest Average Salary: {department.Name}");
        foreach (var emp in department.eployees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine(emp);
        }

    }

    private static void AddToDepartament(Employee currentEmployee, string depName)
    {
        var departament = departaments.FirstOrDefault(d => d.Name == depName);
        if (departament == null)
        {
           Department dep = new Department(depName);
            departaments.Add(dep);
            departament = departaments.FirstOrDefault(d => d.Name == depName);
        }
        departament.AddMember(currentEmployee);
    }

    private static Employee EmployeeParse(string[] tokens)
    {
        var name = tokens[0];
        var salary = double.Parse(tokens[1]);
        int age = -1;
        string mail = "n/a";
        if (tokens.Length == 5)
        {
            var tokenIsAge = int.TryParse(tokens[4], out age);
            if (!tokenIsAge) {mail = tokens[4]; age = -1;}
            else age = int.Parse(tokens[4]);
        }
        else if (tokens.Length > 5) { age = int.Parse(tokens[5]); mail = tokens[4]; }
        return new Employee(name, salary, mail, age);
    }
}