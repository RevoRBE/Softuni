using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;


public class Employee
{
    private string name;
    private string mail;
    public int age;

    public double Salary { get; set; }

    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public string Mail
    {
        set { this.mail = value; }
        get { return this.mail; }
    }

    public int Age
    {
        set { this.age = value; }
        get { return this.age; }
    }

    public Employee(string name, double salary, string mail = "n/a", int age = -1)
    {
        this.name = name;
        this.Salary = salary;
        this.mail = mail;
        this.age = age;
    }


    public override string ToString()
    {
        return String.Format($"{this.Name} {this.Salary:F2} {this.Mail} {this.Age}");
    }
}