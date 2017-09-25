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
        builder.Append('+' + string.Concat(Enumerable.Repeat('-', n - 2)) + '+').AppendLine();
        for (int i = 0; i < n - 2; i++)
        {
            builder.Append('|' + string.Concat(Enumerable.Repeat('-', n - 2)) + '|').AppendLine();
        }
        builder.Append('+' + string.Concat(Enumerable.Repeat('-', n - 2)) + '+').AppendLine();
        string str = builder.ToString();                
        char[] charr = new char[str.Length];         
        str.CopyTo(0, charr, 0, str.Length);
        var regex = new Regex(@"(.(?!\r|\n))");
        string replacement = "$1 ";
        var matches = regex.Matches(str);
        var result = regex.Replace(str, replacement);
        Console.WriteLine(result);
        //AddChar(str);
        //AddChar(charr);
        //AddChar1(charr);
        //AddChar2(str);
        //AddChar2(charr);
        Console.ReadLine();
    }
    static void AddChar(string str)            //METHOD1
    {
        var output = str.Aggregate(string.Empty, (item, current) => (item + " ") + current);
        Console.WriteLine(output);
    }
    static void AddChar(char[] charr)          //METHOD1
    {
        var output = charr.Aggregate(string.Empty, (current, item) => current + (item + " "));
        Console.WriteLine(output);
    }
    static void AddChar1(char[] charr)          //METHOD2
    {
        string output = String.Join<char>(" ", charr);
        Console.WriteLine(output);
    }
    static void AddChar2(string str)                    //METHOD3
    {
        string output = string.Empty;
        foreach (char item in str)
        {
            output += item + " ";
        }
        Console.WriteLine(output);
    }
    static void AddChar2(char[] charr)                  //METHOD3
    {
        string output = string.Empty;
        foreach (char item in charr)
        {
            output += item + " ";
        }
        Console.WriteLine(output.Trim());
    }
}