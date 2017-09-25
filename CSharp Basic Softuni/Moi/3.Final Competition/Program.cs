using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            byte dancers = byte.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            var season = Console.ReadLine(); bool seasonB = season == "summer" ? true : false;
            var place = Console.ReadLine(); bool placeB = place == "Bulgaria" ? true : false;
            var price = dancers * points;
            var priceAbroad = price * 1.5;
            var priceAfterDeduct = placeB ? seasonB ? price - price * 0.05 : price - price * 0.08 : seasonB ? priceAbroad - priceAbroad * 0.1 : priceAbroad - priceAbroad * 0.15;
            var charity = priceAfterDeduct * 0.75;
            var pricePerPerson = priceAfterDeduct * 0.25 / dancers;
            Console.WriteLine($"Charity - {charity:F2}");
            Console.WriteLine($"Money per dancer - {pricePerPerson:F2}");
            Console.ReadLine();
        }
    }
}
