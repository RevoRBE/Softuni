using System;
using System.Linq;

class DiagonalDifference
{
    static void Main()
    {
        var dimensions = int.Parse(Console.ReadLine());
        int[,] sQmatrix = new int[dimensions, dimensions];
        int sum1 = 0, sum2 = 0, j = 0;
        for (int i = 0; i < dimensions; i++)
        {
            var oneD = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var num in oneD)
            {
                sQmatrix[i, j++] = num;
            }
            j = 0;
        }
        var verticalMirror = VerticalMirror(sQmatrix);

        j = sQmatrix.GetLength(0)-1;
        for (int i = 0; i < sQmatrix.GetLength(0); i++, j--)
        {
            sum1 += sQmatrix[i, i];
            sum2 += verticalMirror[i, i];
        }
        Console.WriteLine("{0}", Math.Abs(sum1 - sum2));
    }

   
    private static int[,] VerticalMirror(int[,] mirrorMe)
    {
        int[,] mirrored = new int[mirrorMe.GetLength(0), mirrorMe.GetLength(1)];
        for (int i = 0; i < mirrorMe.GetLength(0); i++)
        {
            for (int j = 0; j < mirrorMe.GetLength(1); j++)
            {
                mirrored[i, j] = mirrorMe[i, mirrorMe.GetLength(1)-1-j];
            }
        }
        return mirrored;
    }
}