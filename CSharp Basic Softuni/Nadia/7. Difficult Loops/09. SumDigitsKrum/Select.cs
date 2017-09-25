using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class useofselect
{
    static void Main(string[] args)
    {
        var charr = Console.ReadLine().ToArray();
        int[] intarr = charr.Select(x => x - '0').ToArray();
        Console.WriteLine(intarr.Sum());
        Console.ReadLine();
    }
}