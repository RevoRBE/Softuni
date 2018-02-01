using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RubiksMatrix
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int nCom = int.Parse(Console.ReadLine());
        int rows = dimentions[0];
        int cols = dimentions[1];
        var matrix = FillMatrix(rows, cols);
        var commands = new string[nCom][];
        for (int i = 0; i < nCom; i++)
        {
            commands[i] = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        //Everyday I'm shuffleing
        foreach (var command in commands)
        {
            var position = int.Parse(command[0]);
            var direction = command[1][0];
            var rotations = int.Parse(command[2]);
            var q = new Queue<int>();
            if (direction.Equals('u') || direction.Equals('d'))
            {
                for (int i = 0; i < rows; i++)
                    q.Enqueue(matrix[i, position]);
                var qr = new Queue<int>(q.Reverse().ToArray());
                for (int i = 0; i < rotations % rows; i++)
                {
                    if (direction.Equals('u')) q.Enqueue(q.Dequeue());
                    if (direction.Equals('d')) qr.Enqueue(qr.Dequeue());
                }
                if (direction.Equals('d')) q = new Queue<int>(qr.Reverse().ToArray());
                for (int i = 0; i < rows; i++)
                    matrix[i, position] = q.Dequeue();
            }
            else
            {
                for (int i = 0; i < cols; i++)
                    q.Enqueue(matrix[position, i]);
                var qr = new Queue<int>(q.Reverse().ToArray());
                for (int i = 0; i < rotations % cols; i++)
                {
                    if (direction.Equals('l')) q.Enqueue(q.Dequeue());
                    if (direction.Equals('r')) qr.Enqueue(qr.Dequeue());
                }
                if (direction.Equals('r')) q = new Queue<int>(qr.Reverse().ToArray());
                for (int i = 0; i < cols; i++)
                    matrix[position, i] = q.Dequeue();
            }
        }

        //OUTPUT
        var indexes = new int[rows * cols + 1][];
        for (int row = 0; row < rows; row++)
            for (int col = 0; col < cols; col++)
                indexes[matrix[row, col]] = new int[] { row, col };

        for (int row = 0, i = 1; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] == i) Console.WriteLine("No swap required");
                else
                {
                    var erow = indexes[i][0];
                    var ecol = indexes[i][1];
                    var temp = matrix[row, col];
                    indexes[temp] = new int[]{erow, ecol};
                    matrix[row, col] = matrix[erow, ecol];
                    matrix[erow, ecol] = temp;
                    Console.WriteLine($"Swap ({row}, {col}) with ({erow}, {ecol})");
                }
                i++;
            }
        }

    }
    private static int[,] FillMatrix(int rows, int cols)
    {
        int[,] filled = new int[rows, cols];
        for (int row = 0, i = 1; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                filled[row, col] = i++;
            }
        }
        return filled;
    }
}