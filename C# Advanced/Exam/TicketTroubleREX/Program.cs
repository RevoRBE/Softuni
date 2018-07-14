using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TicketTroubleREX
{
    class Program
    {
        static void Main()
        {
            string dest = Console.ReadLine();
            string raw = Console.ReadLine();
            
            string pattern = @"((?<a>\[)|{)[^{}\[\]]*?(?(a){|\[)([A-Z\s{1}]{6})(?(a)}|\])[^{}\[\]]*?((?(a){)|\[)([A-Z1-9]{2,3})(?(a)}|\])[^{}\[\]]*?(?(a)\]|})";
            string pattern1 = @"((?<a>\[)|{)\S*?(?(a){|\[)([A-Z ]{5,})(?(a)}|\])\S*?((?(a){)|\[)([A-Z1-9]{3})(?(a)}|\])\S*?(?(a)\]|})";

            MatchCollection matches = Regex.Matches(raw, pattern);
            var list = new List<string>();
            foreach (Match match in matches)
            {
                if (match.Groups[2].ToString() == dest)
                {
                    string add = match.Groups[4].ToString();
                    list.Add(add);
                }
            }
            int valids = list.Count;
            if (valids == 2)
            {
                Console.WriteLine($"You are traveling to {dest} on seats {list[0]} and {list[1]}.");
            }

            else
            {
                Dictionary<int,string> more = new Dictionary<int,string>();
                foreach (var item in list)
                {
                    var row = int.Parse(item.Substring(1));
                    var pos = item.Substring(0, 1);
                    if (!more.ContainsKey(row))
                    {
                        more.Add(row, pos);
                    }
                    else
                    {
                        var o1 = more[row]+row;
                        var o2 = item.ToString();
                        Console.WriteLine($"You are traveling to {dest} on seats {o1} and {o2}.");
                    }
                }
            }
        }
    }
}
