using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            var lane = new Queue<string>();
            int greenDur = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int dur = greenDur + freeWindow;
            int carsPassed = 0;
            int greenRe = greenDur;
            bool crash = false;
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    lane.Enqueue(input);
                }
                else
                {
                    greenRe = greenDur;
                    while (greenRe > 0)
                    {
                        if (dur >= lane.Peek().Length)
                        {
                            carsPassed++;
                            greenRe -= lane.Peek().Length;
                            lane.Dequeue();
                        }
                        else Crash(lane, dur);

                        if (lane.Count == 0) break;
                        
                        if (greenRe > 0)
                        {
                            dur = greenRe + freeWindow;
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine($"Everyone is safe.\n{carsPassed} total cars passed the crossroads.");
        }

        private static void Crash(Queue<string> lane, int dur)
        {
            Console.WriteLine("A crash happened!");

            char atChar = lane.Peek()[dur];
            Console.WriteLine($"{lane.Peek()} was hit at {atChar}.");
            Environment.Exit(0);
        }
    }
}
