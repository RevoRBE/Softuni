using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private T obj;
    public Box(T value)
    {
        obj = value;
    }
    public override string ToString()
    {
        string classFullName = obj.GetType().FullName; 
        return $"{classFullName}: {obj}";
    }
}