using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSum
{
    static void Main(string[] args)
    {
        int[] dimentions = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        int rows = dimentions[0], cols = dimentions[1];
        int[,] matrix = FillMatrix(rows, cols);
        var maxSumStartIndxs = new int[] { 0, 0, Int32.MinValue };
        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                var sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 2, j] + matrix[i, j + 2] +
                          matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (maxSumStartIndxs[2] < sum)
                {
                    maxSumStartIndxs[0] = i;
                    maxSumStartIndxs[1] = j;
                    maxSumStartIndxs[2] = sum;
                }
            }
        }

        Console.WriteLine($"Sum = {maxSumStartIndxs[2]}");
        for (int i = maxSumStartIndxs[0]; i < maxSumStartIndxs[0]+3; i++)
        {
            for (int j = maxSumStartIndxs[1]; j < maxSumStartIndxs[1]+3; j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }

            Console.WriteLine();
        }
    }

    private static int[,] FillMatrix(int rows, int cols)
    {
        int[,] filled = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] rowInts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int col = 0; col < cols; col++)
            {
                filled[row, col] = rowInts[col];
            }
        }
        return filled;
    }
}
