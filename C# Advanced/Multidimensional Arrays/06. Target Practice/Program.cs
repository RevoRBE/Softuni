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
       // int[,] stairs = FillMatrix(rows, cols);

    }

    //private static int[,] FillMatrix(int rows, int cols)
    //{
    //    var matrix = new char[rows, cols];
    //    bool isGoingLeft = true;
    //    int startIndex = isGoingLeft ? matrix.GetLength(1) : 0;
    //    int inc
    //}
}