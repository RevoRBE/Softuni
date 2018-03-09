using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KeyRevolver
{
    static void Main()
    {
        var bulletPrice = double.Parse(Console.ReadLine());
        var barrel = int.Parse(Console.ReadLine());
        int[] bulletsArray = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
        int[] locksArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var price = int.Parse(Console.ReadLine());
        Queue<int> bullets = new Queue<int>(bulletsArray);
        Queue<int> locks = new Queue<int>(locksArray);
        int i = 0;
        int shotsMade = 0;

        while (locks.Any() && bullets.Any())
        {
            if (bullets.Dequeue()<=locks.Peek())
            {
                locks.Dequeue();
                Console.WriteLine("Bang!");
            }
            else Console.WriteLine("Ping!");

            if (barrel == ++i && bullets.Any())
            {
                Console.WriteLine("Reloading!");
                i = 0;
            }

            shotsMade++;
        }
        if (!locks.Any())
        {
            double moneyEarned = price - shotsMade * bulletPrice;
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
        }
        else
            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        
    }
}
