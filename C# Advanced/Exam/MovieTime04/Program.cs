using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTime04
{
    class Program
    {
        static void Main()
        {

            string genre = Console.ReadLine();
            string dur = Console.ReadLine();
            Dictionary<string, TimeSpan> choosen = new Dictionary<string, TimeSpan>();
            string input;
            TimeSpan totalTime = default(TimeSpan);
            while ((input = Console.ReadLine()) != "POPCORN!")
            {
                var tokens = input.Split('|');
                totalTime += TimeSpan.Parse(tokens[2]);
                if (tokens[1] == genre)
                {
                    choosen.Add(tokens[0], TimeSpan.Parse(tokens[2]));
                }
            }
            while (true)
            {
                if (dur == "Short")
                {
                    foreach (var film in choosen.OrderBy(f => f.Value).ThenBy(f => f.Key))
                    {
                        Console.WriteLine(film.Key);
                        if ((input = Console.ReadLine()) == "Yes")
                        {
                            Console.WriteLine($"We're watching {film.Key} - {film.Value}");
                            Console.WriteLine($"Total Playlist Duration: {totalTime}");
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var film in choosen.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                    {
                        Console.WriteLine(film.Key);
                        if ((input = Console.ReadLine()) == "Yes")
                        {
                            Console.WriteLine($"We're watching {film.Key} - {film.Value}");
                            Console.WriteLine($"Total Playlist Duration: {totalTime}");
                            break;
                        }
                    }
                }
                break;
            }
        }
    }
}
