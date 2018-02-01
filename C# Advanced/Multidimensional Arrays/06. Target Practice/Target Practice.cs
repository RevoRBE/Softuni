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
        string snake = Console.ReadLine();

        int[] shot = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
        var matrix = new int[rows, cols];
        char[,] stairs = FillMatrix(rows, cols, snake);
        Console.WriteLine();
    }

    private static char[,] FillMatrix(int rows, int cols, string snake)
    {
        var matrix = new char[rows, cols];
        bool isGoingLeft = true;
        int index = isGoingLeft ? matrix.GetLength(1) : 0;
        int increment = isGoingLeft ? -1 : 1;
        int snakeIndex = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, index] = snake[snakeIndex++];
                if (snakeIndex > snake.Length) snakeIndex = 0;
                index += increment;
            }

            isGoingLeft = !isGoingLeft;
        }

        return matrix;
    }
}