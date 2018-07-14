using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Sneaking
{
    static char[][] board;
    static int[] sam;
    static int[] niko;
    static int rows;
    static int cols;
    static bool samLives = true;
    static bool nikoLives = true;

    static void Main(string[] args)
    {
        sam = new int[2];
        niko = new int[2];
        rows = int.Parse(Console.ReadLine());
        board = new char[rows][];

        for (int row = 0; row < board.Length; row++)
        {
            board[row] = Console.ReadLine().ToCharArray();
        }
        cols = board[0].Length;

        //var moves = new Queue<char>(Console.ReadLine().ToCharArray().ToArray());
        findPlayers();
        while (samLives && nikoLives)
        {
            enemiesMove();
            check();
            if (!samLives) break;
            //samMoves(moves);
            check();
            if (sam[0]== niko[0])
            {
                board[niko[0]][niko[1]] = 'X';
                nikoLives = false;
            }
        }

        Console.WriteLine(samLives?"Nikoladze killed!":$"Sam died at {sam[0]}, {sam[1]}");
        print();
        

    }

    private static void print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(board[i][j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void samMoves(Queue<char> moves)
    {
        int i = sam[0];
        int j = sam[1];
        //if (!moves.Any())
        {
            return;
        }
        switch (moves.Dequeue())
        {
            case 'U':
                board[i - 1][j] = 'S';
                board[i][j] = '.';
                sam[0]--;
                break;
            case 'D':
                board[i + 1][j] = 'S';
                board[i][j] = '.';
                sam[0]++;
                break;
            case 'L':
                board[i][j - 1] = 'S';
                sam[1]--;
                board[i][j] = '.';
                break;
            case 'R':
                board[i][j + 1] = 'S';
                sam[1]++;
                board[i][j] = '.';
                break;
            default:
                break;
        }
    }

    private static void enemiesMove()
    {
        for (int i = 0; i < rows; i++)
        {
            if (i == niko[0]) continue;
            for (int j = 0; j < cols; j++)
                if (board[i][j] == 'b' || board[i][j] == 'd')
                {
                    if (j == 0 && board[i][j] == 'd')
                    {
                        board[i][j] = 'b';
                        check();
                        if (!samLives) return;
                    }
                    else if (j == cols - 1 && board[i][j] == 'b')
                    {
                        board[i][j] = 'd';
                        check();
                        if (!samLives) return;
                    }
                    else if (board[i][j] == 'b')
                    {
                        board[i][j + 1] = 'b';
                        board[i][j] = '.';
                        break;
                    }
                    else
                    {
                        board[i][j - 1] = 'd';
                        board[i][j] = '.';
                    }
                }
        }
    }


    private static void check()
    {
        for (int i = 0; i < sam[1]; i++)
            if (board[sam[0]][i] == 'b')
            {
                samLives = false;
                board[sam[0]][sam[1]] = 'X';
                return;
            }

        for (int i = sam[1] + 1; i < cols; i++)
            if (board[sam[0]][i] == 'd') 
            {
                samLives = false;
                board[sam[0]][sam[1]] = 'X';
                return;
            }
    }

    private static void findPlayers()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'N')
                {
                    niko[0] = i;
                    niko[1] = j;
                    break;
                }

                if (board[i][j] == 'S')
                {
                    sam[0] = i;
                    sam[1] = j;
                    break;
                }
            }
        }
    }
}
