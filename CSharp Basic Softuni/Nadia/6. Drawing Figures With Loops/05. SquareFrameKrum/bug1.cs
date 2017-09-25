using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class bug1
{
       static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();
        builder.Append("+" + string.Concat(Enumerable.Repeat('-', n - 2)) + '+').AppendLine();
        for (int i = 0; i < n - 2; i++)
        {
            builder.Append('|' + string.Concat(Enumerable.Repeat('-', n - 2)) + '|').AppendLine();
        }
        builder.Append('+' + string.Concat(Enumerable.Repeat('-', n - 2)) + '+').AppendLine();

        string str = builder.ToString();                //TO string
        char[] charr = new char[builder.Length];         //TO char[]
        builder.CopyTo(0, charr, 0, builder.Length);
        Console.WriteLine(str);
        Console.WriteLine(charr);
        AddChar(str);
        AddChar(charr);
        AddChar1(charr);
        AddChar2(str);
        AddChar2(charr);
    
        //var plus = "+";                                //ADD +
        //plus += output2;

        Console.ReadLine();
    }
    static void AddChar(string str)            //METHOD1
    {
        var output = str.Aggregate(string.Empty, (current, item) => current + (item + " ")); 
        Console.WriteLine(output);
    }
    static void AddChar(char[] charr)          //METHOD1
    {
        var output = charr.Aggregate(string.Empty, (current, item) => current + (item + " ")); 
        Console.WriteLine(output);
    }
    static void AddChar1(char[] charr)          //METHOD2
    {
        Console.WriteLine(String.Join<char>(" ", charr));
    }
    static void AddChar2(string str)                    //METHOD3
    {
        string strtr = string.Empty;
        foreach (char item in str)
        {
            strtr += item + " ";
        }
        Console.WriteLine(strtr);
    }
    static void AddChar2(char[] charr)                  //METHOD3
    {
        string str = string.Empty;                    
        foreach (char item in charr)
        {
            str += item + " ";
        }
        Console.WriteLine(str.Trim());
    }
}