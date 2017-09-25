using System;


namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int x2 = h * 3;
            int y1 = 0;
            int y2 = h;

            int a1 = h;
            int a2 = h * 2;
            int b1 = h;
            int b2 = h * 4;

            if (((x > x1) && (x < x2)) && ((y > y1) && (y < y2)) ||
                ((x > a1) && (x < a2)) && ((y > b1) && (y < b2)) || (x > a1 && x < a2) && y == b1) 
            {
                Console.WriteLine("inside");
            }
            else if ((x >= x1 && x <= x2) && (y == y1 || y == y2) ||
                    (y >= y1 && y <= y2) && (x == x1 || x == x2) ||
                    (x >= a1 && x <= a2) && (y == b1 || y == b2) ||
                    (y >= b1 && y <= b2) && (x == a1 || x == a2))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
