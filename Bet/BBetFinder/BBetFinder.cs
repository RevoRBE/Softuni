using System;

namespace ConsoleApp1
{
    class BKBBetFinder
    {
        static void Main(string[] args)
        {
            double num;
            do
            {
                try
                {
                    num = double.Parse(Console.ReadLine());
                    num = Math.Ceiling(num / (num - 1) * 100);
                    string numasstring = num.ToString();
                    numasstring = numasstring.Length == 3 ? numasstring.Insert(1, ".") : numasstring.Insert(2, ".");
                    Console.WriteLine(numasstring);
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}