using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace Knight_Game
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var matrix = new char[num, num];
            var knightsPositions = new List<Knight>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'K')
                    {
                        var knight = new Knight(row, col);
                        knightsPositions.Add(knight);
                    }
                }
            }


            foreach (var knight in knightsPositions)
                GetIntteract(knight, matrix);

            int counter = 0;
            while (true)
            {
                bool doInterract = CheckIfInterract(knightsPositions, matrix);

                if (doInterract)
                {
                    var bro = knightsPositions.OrderByDescending(x => x.interract).First();
                    matrix[bro.row, bro.col] = '0';
                    knightsPositions.Remove(bro);
                    knightsPositions.ForEach(x => x.interract = 0);
                    foreach (var knight in knightsPositions)
                        GetIntteract(knight, matrix);
                    counter++;
                }
                else break;
            }
            Console.WriteLine(counter);
        }

        private static void Printer(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    Console.Write(matrix[i, j]);
                Console.WriteLine();
        }

        private static bool CheckIfInterract(List<Knight> knightsPositions, char[,] matrix)
        {
            foreach (var knight in knightsPositions)
                for (int row = 0; row < matrix.GetLength(0); row++)
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {


                        if (matrix[row, col] == 'K' && Math.Abs(row - knight.row) == 2)
                            if (Math.Abs(col - knight.col) == 1)
                                return true;
                        else if (matrix[row, col] == 'K' && Math.Abs(col - knight.col) == 2)
                            if (Math.Abs(row - knight.row) == 1)
                                return true;
                    }

            return false;
        }

        private static void GetIntteract(Knight knight, char[,] matrix)
        {
            int currentRow = knight.row;
            int currentCol = knight.col;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'K' && Math.Abs(row - currentRow) == 2)
                        if (Math.Abs(col - currentCol) == 1)
                            knight.interract++;

                    if (matrix[row, col] == 'K' && Math.Abs(col - currentCol) == 2)
                        if (Math.Abs(row - currentRow) == 1)
                            knight.interract++;
                }
            }
        }




        public class Knight
        {
            public int row;

            public int col;

            public int interract = 0;
            public Knight(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }
    }
}