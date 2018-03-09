using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();
        for (int i = 0; i < lines; i++)
            sb.Append(Console.ReadLine());
        var text = sb.ToString();
        string pattern = @"((?<a>{)|\[).*?(\d{3,}).*?(?(a)}|\])";
        MatchCollection matches = Regex.Matches(text, pattern);
        sb.Clear();
        var list = new List<int>();
        foreach (Match match in matches)
        {
            if (match.Groups[2].Length % 3 != 0)
            {
                continue;
            }
            var num = match.Groups[2].ToString();
            var l = match.Groups[0].Length;
            double parts = 3;
            int k = 0;
            var output = num
                .ToLookup(c => Math.Floor(k++ / parts))
                .Select(e => new String(e.ToArray()));
            var output1 = num
                .ToLookup(c => Math.Floor(k++ / parts))
                .Select(e => new String(e.ToArray()));
            foreach (var n in output)
            {
                list.Add(int.Parse(n) - l);
            }
            foreach (var n in list)
            {
                sb.Append((char)n);
            }
            list.Clear();
        }
        Console.WriteLine(sb.ToString());
    }
}
