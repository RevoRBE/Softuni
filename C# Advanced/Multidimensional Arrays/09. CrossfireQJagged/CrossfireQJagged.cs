using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Target_Practice
{

    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int rows = dimentions[0];
        int cols = dimentions[1];
        string input = Console.ReadLine();
        int[][] matrix = FillMatrix(rows, cols);
        while (input != "Nuke it from orbit")
        {
            matrix = FireShot(input, matrix);
            matrix = Gravity(matrix);
            input = Console.ReadLine();
        }
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i][j] != 0) Console.Write($"{matrix[i][j]} ");
            }
            if (matrix[i][0] != 0)
                Console.WriteLine();
        }
    }

    private static int[][] Gravity(int[][] matrix) //2TheLeft
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int empty = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row][col] == 0) empty++;
                else if (empty != 0)
                {
                    matrix[row][col - empty] = matrix[row][col];
                    matrix[row][col] = 0;
                }
            }
        }
        return matrix;
    }

    private static int[][] FireShot(string strshot, int[][] matrix)
    {
        int[] shot = strshot.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int trow = shot[0];
        int tcol = shot[1];
        int radius = shot[2];
        if (tcol > -1 && tcol < matrix.GetLength(1))
            for (int row = Math.Max(0, trow - radius); row <= Math.Min(matrix.GetLength(0) - 1, trow + radius); row++)
                matrix[row][tcol] = 0;
        if (trow > -1 && trow < matrix.GetLength(0))
            for (int col = Math.Max(0, tcol - radius); col <= Math.Min(matrix.GetLength(1) - 1, tcol + radius); col++)
                matrix[trow][col] = 0;
        return matrix;
    }

    private static int[][] FillMatrix(int rows, int cols)
    {
        var matrix = new int[rows][];
        //int i = 1;
        //for (int row = 0; row < rows; row++)
        //{
        //    matrix[row] = new [cols]{};
        //}
        return matrix;
    }
}

//Още един вариант за четене на матрица :) char[][] board = new char[boardSize][];
//board = board .Select(w => w = new char[boardSize]).Select(w => w = Console.ReadLine().ToCharArray()).ToArray();