using System;

namespace _06.PodoubleORectangleBorder
{
    class PodoubleORectangleBorder
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool inside = x >= x1 && x <= x2 && y >= y1 && y <= y2;
            bool onBorder = inside && x == x1 || x == x2 || y == y1 || y == y2;
            Console.WriteLine(onBorder?"Border" : "Inside / Outside");
 
            //x >= x1 && x <= x2 && y == y1 || // bottom
            //x >= x1 && x <= x2 && y == y2 || // top
            //x == x1 && y >= y1 && y <= y2 || // left
            //x == x2 && y >= y1 && y <= y2   // right
            //if ((x >= x1 && x <= x2) && (y == y1 || y == y2) ||
            //    (y >= y1 && y <= y2) && (x == x1 || x == x2))
            //{

            //bool isBottomOrTop = x >= x1 && x <= x2 && (y == y1 || y == y2);
            //bool isLeftOrRight = y >= y1 && y <= y2 && (x == x1 || x == x2);

            //if (isBottomOrTop || isLeftOrRight)
            //{ 
            //    Console.WriteLine("Border");
            //}
            //else
            //{
            //    Console.WriteLine("Inside / Outside");
            //}
        }
    }
}