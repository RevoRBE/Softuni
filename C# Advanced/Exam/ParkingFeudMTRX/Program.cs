using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class ParkingFeudMTRX
{
    static int[] sam;
    static string[,] parking;
    static int moves;

    static void Main(string[] args)
    {
        CreateParking();

        int rows = parking.GetLength(0);
        int cols = parking.GetLength(1);

        PlaceDrivers(rows);


        bool duplicates = false;
        while (true)
        {
            var spots = Console.ReadLine().Split().ToArray();
            var firstEl = spots.First();
            foreach (var item in spots.Skip(1))
            {
                if (firstEl == item) duplicates = true;
            }
            int srow = int.Parse(firstEl[1].ToString()) - 1;
            int scol = firstEl[0] - 64;
            bool goingleft = false;
            if (!duplicates)
            {
                for (int i = 1; i <= rows; i++)
                {
                    if (i % 2 == 0)
                    {
                        i++;
                        moves++;
                    }
                    if (!goingleft)
                    {

                        for (int j = 0; j < cols; j++)
                        {

                            moves++;
                            if (srow == i + 1 || srow == i - 1 && scol == j + 1 || scol == j - 1)
                            {
                                i = rows;
                                break;
                            }
                            goingleft = true;
                        }
                    }
                    else
                        for (int j = cols - 1; j >= 0; j--)
                        {
                            moves++;
                            if (srow == i + 1 || srow == i - 1 && scol == j + 1 || scol == j - 1)
                            {
                                i = rows;
                                break;
                            }
                            goingleft = false;
                        }
                }
            }
            Console.WriteLine($"Parked successfully at {firstEl}.\nTotal Distance Passed: {moves}");
            break;
        }
    }

    private static void CreateParking()
    {
        var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = num[0] * 2 - 1;
        int cols = num[1] + 2;
        parking = new string[rows, cols];
    }

    private static void PlaceDrivers(int rows)
    {
        int entrance = int.Parse(Console.ReadLine());
        parking[entrance, 0] = "sam";
        int driverO = 1;
        for (int i = 1; i < rows; i += 2)
        {
            if (parking[i, 0] == null)
                parking[i, 0] = "driver" + driverO++;
        }
    }
}