using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;


public class Family
{
    private List<Person> family;
    public Family ()
    {
        this.family = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.family.Add(member);
    }
    public Person GetOldestMember()
    {
        return this.family.OrderByDescending(p => p.age).First();
    }
    public List<Person> task()
    {
        return this.family.Where(p => p.age > 30).OrderBy(n => n.Name).ToList();
    }
}
