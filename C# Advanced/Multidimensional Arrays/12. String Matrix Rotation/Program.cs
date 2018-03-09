using System;
using System.Collections.Generic;
using System.Linq;

class StringMatrixRotations
{
    static void Main()
    {
        string degString = Console.ReadLine();
        degString = degString.Substring(7, degString.IndexOf(')') - 7);
        int degrees = int.Parse(degString) % 360;
        string text = Console.ReadLine();
        List<string> listMatrix = new List<string>();

        while (text != "END")
        {
            listMatrix.Add(text);
            text = Console.ReadLine();
        }
        int longestWord = listMatrix.Max(r => r.Length); //ВЪПРОС !

        for (int i = 0; i < listMatrix.Count; i++)
        {
            if (listMatrix[i].Length < longestWord)
            {
                listMatrix[i] = listMatrix[i] + new string(' ', longestWord - listMatrix[i].Length);
            }
        }

        if (degrees == 0)
            foreach (var rotate360 in listMatrix)
                Console.WriteLine(rotate360);

        else if (degrees == 180)
            for (int i = listMatrix.Count - 1; i >= 0; i--)
            {
                for (int j = longestWord - 1; j >= 0; j--)
                    Console.Write(listMatrix[i][j]);
                Console.WriteLine();
            }

        else
        {
            char[,] diagonalMirror = new char[longestWord, listMatrix.Count];

            for (int row = 0; row < longestWord; row++)     //DIAGONAL MIRROR
                for (int col = 0; col < listMatrix.Count; col++)
                    diagonalMirror[row, col] = listMatrix[col][row];

            if (degrees == 90)       //VERTICAL MIRROR OF THE DIAGONAL MIRROR
                for (int i = 0; i < diagonalMirror.GetLength(0); i++)
                { 
                    for (int j = diagonalMirror.GetLength(1) - 1; j >= 0; j--)
                        Console.Write(diagonalMirror[i, j]);
                    Console.WriteLine();
                }

            if (degrees == 270)      //HORIZONTAL MIRROR OF THE DIAGONAL MIRROR
                for (int i = diagonalMirror.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < diagonalMirror.GetLength(1); j++)
                        Console.Write(diagonalMirror[i, j]);
                    Console.WriteLine();
                }
        }
    }
}