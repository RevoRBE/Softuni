using System;
using System.Collections.Generic;
using System.Linq;

class TruckTour
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var stations = new Queue<int[]>();

        for (int i = 0; i < n; i++)
        {
            var st = Console.ReadLine().Split().Select(int.Parse).ToArray();
            stations.Enqueue(st);
        }
        for (int currentStart = 0; currentStart < n-1; currentStart++)
        {
            int fuel = 0;
            bool isSolution = true;
            for (int pumpsPassed = 0; pumpsPassed < n; pumpsPassed++)
            {
                var currentPump = stations.Dequeue();
                int pumpFuel = currentPump[0];
                int nextPumpDistance = currentPump[1];
                stations.Enqueue(currentPump);

                fuel += pumpFuel - nextPumpDistance;
                if (fuel < 0)
                {
                    currentStart += pumpsPassed;
                    isSolution = false;
                    break;
                }
            }
            if (isSolution)
            {
                Console.WriteLine(currentStart);
                Environment.Exit(0);
            }
        }
        Console.WriteLine(string.Join(" ", stations));
    }
}