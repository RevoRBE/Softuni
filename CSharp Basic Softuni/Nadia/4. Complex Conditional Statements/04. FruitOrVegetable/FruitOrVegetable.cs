using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FruitOrVegetable
{
    class CheckCollections
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string[] fruit = { "banana", "lemon", "apple", "kiwi", "cherry", "grapes" };
            string[] vegetable = {"tomato","cucumber","pepper","carrot"};
            Console.WriteLine(fruit.Any(input.Contains)?"fruit":vegetable.Any(input.Contains)?"vegetable":"unknown");
        }
    }
}
