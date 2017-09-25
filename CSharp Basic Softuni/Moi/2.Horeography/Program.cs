using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Horeography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double perc = Math.Ceiling(steps / days / steps * 100);
            double percStepsPerDay = perc / dancers;

            Console.WriteLine(perc>13?$"No, They will not succeed in that goal! Required {percStepsPerDay:F2}% steps to be learned per day." : $"Yes, they will succeed in that goal! {percStepsPerDay:F2}%.");
        }
    }
}
