using System;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main()
        {
            Regex pattern = new Regex(@"([a-zA-Z]+)(\S+)\1");//^(?<start>[A-Za-z]+)[<\\\|]{1}.*[<\|\\]{1}(?<end>[A-Za-z]+)$

            string inputPattern = "HeypalHey______how_ya_how_doin_how";

            var match = pattern.Matches(inputPattern);

            string start = match.Groups["start"].Value;
            string end = match.Groups["end"].Value;

            Regex stringPattern = new Regex($@"{start}(?<word>.*?){end}");

            string input = Console.ReadLine();

            MatchCollection matches = stringPattern.Matches(input);

            string result = string.Empty;

            foreach (Match word in matches)
            {
                result += word.Groups["word"].Value;
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
                return;
            }
            Console.WriteLine(result);
        }
    }
}