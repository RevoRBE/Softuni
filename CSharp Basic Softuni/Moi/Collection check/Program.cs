using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<String> yes = new List<string>{"zero","one","two","three","four","five","six","seven","eight","nine"};
        Console.WriteLine(yes.Count > num ? yes[num] : "number too big");
    }
}