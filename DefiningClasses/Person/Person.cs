using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;


public class Person
{
    private string name;
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }
    public int age;
    public int Age
    {
        set { this.age = value; }
        get { return this.age; }
    }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }
    public Person(int age) : this()
    {
        this.age = age;
    }
    public Person(string name, int age) : this(age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return this.name + " - " + this.age;
    }
}
