using System;
using System.Collections.Generic;
using System.Linq;

namespace HitList
{
    class Program
    {
        private static Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();
        static int infoIndex = 0;

        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end transmissions")
            {
                string[] args = input.Split('=');
                string name = args[0];
                string[] skills = args[1].Split(";:".ToCharArray());
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string, string>());
                    }
                    for (int i = 0; i < skills.Length; i += 2)
                    {
                        if (!data[name].ContainsKey(skills[i]))
                        {
                            data[name].Add(skills[i], skills[i + 1]);
                        }
                        data[name][skills[i]] = skills[i + 1];
                    }

                }
            }
            var input1 = Console.ReadLine().Split();

            GenerateReport(input1[1]);
            Console.WriteLine($"Info index: {0}", infoIndex);
            if (num < infoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {num - infoIndex} more info.");
            }
        }

        private static void GenerateReport(string input)
        {
            Console.WriteLine($"Info on {input}:");
            foreach (var item in data[input].OrderBy(p=>p.Key))
            {
                infoIndex += item.Key.Length + item.Value.Length;
                Console.WriteLine($"---{item.Key}: {item.Value}");
            }
        }
    }
}
