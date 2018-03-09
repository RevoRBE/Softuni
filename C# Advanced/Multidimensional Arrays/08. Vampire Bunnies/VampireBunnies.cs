﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Radioactive_Bunnies
{
    static int[] playerPosition = new int[2];
    static bool gameOverWon = false;
    static bool gameOverDead = false;

    static void Main(string[] args)
    {
        char[][] lair = GetMatrix();
        string commands = Console.ReadLine();

        while (!gameOverDead && !gameOverWon)
        {
            foreach (char command in commands)
            {
                UpdatePlayer(lair, command);
                UpdateBunnies(lair);
                if (gameOverWon || gameOverDead) break;
            }
        }
        PrintMatrix(lair);
        Console.WriteLine("{0}: {1}",
            gameOverWon ? "won" : "dead",
            string.Join(" ", playerPosition));
    }

    private static void UpdateBunnies(char[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        for (int row = 0; row < rows; row++)
            for (int col = 0; col < cols; col++)
                if (matrix[row][col] == 'B')
                    // populate upper, lower, left & right '.' positions
                    for (int r = Math.Max(0, row - 1); r <= Math.Min(row + 1, rows - 1); r++)
                        for (int c = Math.Max(0, col - 1); c <= Math.Min(col + 1, cols - 1); c++)
                        {
                            double distanceToBunny = Math.Sqrt(Math.Pow(row - r, 2) + Math.Pow(col - c, 2));
                            if (distanceToBunny == 1)
                            {
                                if (matrix[r][c] == 'P')
                                {
                                    gameOverDead = true;
                                    matrix[r][c] = 'b';
                                }
                                else if (matrix[r][c] == '.') matrix[r][c] = 'b';
                            }
                        }
        // update new bunnies: 'b' => 'B'
        for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            if (matrix[row][col] == 'b')
                matrix[row][col] = 'B';
    }

    private static void UpdatePlayer(char[][] matrix, char command)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int stepRow = 0;
        int stepCol = 0;
        switch (command)
        {
            case 'R': stepCol++; break;
            case 'L': stepCol--; break;
            case 'U': stepRow--; break;
            case 'D': stepRow++; break;
        }
        int moveToRow = playerPosition[0] + stepRow;
        int moveToCol = playerPosition[1] + stepCol;
        bool isInside = moveToRow >= 0 && moveToRow < rows &&
                        moveToCol >= 0 && moveToCol < cols;
        if (!isInside)
        {
            gameOverWon = true;
            matrix[playerPosition[0]][playerPosition[1]] = '.';
        }
        else if (matrix[moveToRow][moveToCol] == 'B')
        {
            gameOverDead = true;
            playerPosition[0] = moveToRow;
            playerPosition[1] = moveToCol;
        }
        else
        {
            matrix[moveToRow][moveToCol] = 'P';
            matrix[playerPosition[0]][playerPosition[1]] = '.';
            playerPosition[0] = moveToRow;
            playerPosition[1] = moveToCol;
        }
    }

    static char[][] GetMatrix()
    {
        int[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        int rows = dimensions[0];
        char[][] matrix = new char[rows][];
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().ToCharArray();
            if (matrix[row].Contains('P'))
            {
                playerPosition[0] = row;
                for (int i = 0; i < matrix[row].Length; i++)
                    if (matrix[row][i] == 'P') playerPosition[1] = i;
            }
        }
        return matrix;
    }

    static void PrintMatrix(char[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
            Console.WriteLine(string.Join("", matrix[row]));
    }
}