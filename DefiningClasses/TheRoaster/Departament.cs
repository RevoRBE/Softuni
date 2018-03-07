using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;


public class Department 
{
    public List<Employee> eployees;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Department (string name)
    {
        this.eployees  = new List<Employee>();
        this.name = name;
    }

    public void AddMember(Employee member)
    {
        this.eployees .Add(member);
    }

    public Double AverageSalary => this.eployees.Select(employee => employee.Salary).Average();
    //public Employee GetOldestMember()
    //{
    //    return this.eployees .OrderByDescending(p => p.age).First();
    //}
    //public List<Employee> task()
    //{
    //    return this.eployees .Where(p => p.age > 30).OrderBy(n => n.Name).ToList();
    //}
}
