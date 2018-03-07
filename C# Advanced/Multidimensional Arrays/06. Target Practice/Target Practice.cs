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

        char[,] matrix = FillMatrix(rows, cols, snake);
        matrix = FireShot(matrix, shot);
        matrix = Gravity(matrix);
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(char[,] matrix)
    {
        StringBuilder sb = new StringBuilder(matrix.GetLength(0)*matrix.GetLength(1));
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sb.Append(matrix[i, j]);
            }
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString().TrimEnd());
    }

    private static char[,] Gravity(char[,] matrix)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int empty = 0;
            for (int row = matrix.GetLength(0)-1 ; row >= 0; row--)
            {
                if (matrix[row, col] == ' ') empty++;
                else if (empty!=0)
                {
                    matrix[row + empty, col] = matrix[row, col];
                    matrix[row, col] = ' ';
                }
            }
        }
        return matrix;
    }

    private static char[,] FireShot(char[,] matrix, int[] shot)
    {
        int trow = shot[0];
        int tcol=shot[1];
        int radius=shot[2];
        for (int row =  0; row <matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int a = trow - row;
                int b = tcol - col;
                double distance = Math.Sqrt(a * a + b * b);
                matrix[row, col] = distance <= radius ? ' ' : matrix[row, col];
            }
        }

        return matrix;
    }

    private static char[,] FillMatrix(int rows, int cols, string snake)
    {
        var matrix = new char[rows, cols];
        bool isGoingLeft = true;
        int snakeIndex = 0;
        for (int row = rows - 1; row >= 0; row--)
        {
            int increment = isGoingLeft ? -1 : 1;
            int index = isGoingLeft ? matrix.GetLength(1) : -1;
            for (int col = 0; col < cols; col++)
            {
                matrix[row, index+= increment] = snake[snakeIndex++];
                if (snakeIndex > snake.Length - 1) snakeIndex = 0;
            }
            isGoingLeft = !isGoingLeft;
        }
        return matrix;
    }
}