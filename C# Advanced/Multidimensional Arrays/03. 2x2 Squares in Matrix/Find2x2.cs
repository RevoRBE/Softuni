using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Find2x2
{
    static void Main(string[] args)
    {
        int[] dimentions = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0], cols = dimentions[1];
        char[,] matrix = FillMatrix(rows, cols);
        int equalCharCounter = 0;
        for (int i = 0; i < rows-1; i++)
        {
            for (int j = 0; j < cols-1; j++)
            {
                if (matrix[i, j] == matrix[i + 1, j] && matrix[i, j + 1] == matrix[i + 1, j + 1] && matrix[i + 1, j] == matrix[i, j + 1] ) equalCharCounter++;
            }
        }

        Console.WriteLine(equalCharCounter);
    }

    private static char[,] FillMatrix(int rows, int cols)
    {
        char[,] filled = new char[rows,cols];
        int j = 0;
        for (int i = 0; i < rows; i++)
        {
            var currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var ch in currentRow)
            {
                filled[i, j++] = ch[0];
            }
            j = 0;
        }
        return filled;
    }
}
