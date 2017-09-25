using System;


namespace _18.PipesInPool
{
    class PipesInPool
    {
        static void Main()
        {
            double poolVolume = double.Parse(Console.ReadLine());
            double firstFlowPipe = double.Parse(Console.ReadLine());
            double secondFlowPipe = double.Parse(Console.ReadLine());
            double offHours = double.Parse(Console.ReadLine());

            double firstPipe = firstFlowPipe * offHours;
            double secondPipe = secondFlowPipe * offHours;

            double totalFlowPool = firstPipe + secondPipe;

            if (poolVolume < totalFlowPool)
            {
                double overFlow = totalFlowPool - poolVolume;

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", offHours, overFlow);
            }
            else
            { 
                double totalPoolPct = Math.Floor(totalFlowPool / poolVolume * 100);
                double firstPipePct = Math.Floor(firstPipe / totalFlowPool * 100);
                double secondPipePct = Math.Floor(secondPipe / totalFlowPool * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", totalPoolPct, firstPipePct, secondPipePct);
            }          
        }
    }
}
