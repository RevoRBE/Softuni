using System;

namespace ConsoleApp1
{
    class BKBBetFinder
    {
        static void Main(string[] args)
        {
            double k1; double k2; double k3; 
            do
            {
                try
                {
                    k1 = double.Parse(Console.ReadLine());
                    k2 = double.Parse(Console.ReadLine());
                    double temp1 = k1 / k2 + 1;
                    double temp2 = k1 - temp1;
                    k3 = k1 / temp2;
                    //k3 = k1 / (k1 - (k1 / k2 + 1));
                    double k3rouded = Math.Ceiling(k3 * 100);
                    string k3AsString = k3rouded.ToString();
                    k3AsString = k3AsString.Length == 3 ? k3AsString.Insert(1, ".") : k3AsString.Insert(2, ".");
                    Console.WriteLine(k3AsString);
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}