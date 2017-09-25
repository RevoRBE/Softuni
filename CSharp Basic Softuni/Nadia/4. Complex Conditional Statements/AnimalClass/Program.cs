using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string[] mammals = new string[] { "dog" };
            string[] reptiles = new string[] { "crocodile", "tortoise", "snake"};

            string animal = Console.ReadLine().ToLower();

            Console.WriteLine(reptiles.Any(animal.Contains) ? "reptile" : mammals.Any(animal.Contains) ? "mammal" : "unknown");
        }
    }
}
