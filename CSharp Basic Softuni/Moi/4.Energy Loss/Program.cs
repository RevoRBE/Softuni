using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int[] arr = new int[days];
            int[] arr2 = new int[days];

            for (int i = 0; i < days; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (i % 2 != 0 && arr[i] % 2 == 0) { arr[i] = 68; continue; }
                if (i % 2 == 0 && arr[i] % 2 == 0) { arr[i] = 49; continue; }
                if (i % 2 != 0 && arr[i] % 2 != 0) { arr[i] = 65; continue; }
                if (i % 2 == 0 && arr[i] % 2 != 0) { arr[i] = 30; continue; }
            }
            var energyWasted = arr.Sum() * dancers;
            var energy = dancers * 100 * days;
            var energyNonWasted = energy - energyWasted;
            var savedEnergyPP = (float)energyNonWasted / dancers / days;
            Console.WriteLine(savedEnergyPP > 50 ? "They feel good! Energy left: {0:F2}" : "They are wasted! Energy left: {0:F2}", savedEnergyPP);
        }
    }
}
