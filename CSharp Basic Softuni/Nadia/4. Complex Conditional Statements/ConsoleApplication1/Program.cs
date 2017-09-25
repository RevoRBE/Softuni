using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int xToFind = int.Parse(Console.ReadLine());
            int yToFind = int.Parse(Console.ReadLine());
            bool top = yToFind <= 4 * h && h <= xToFind && xToFind <= 2 * h;
            bool bot = yToFind <=  h && xToFind <= 3 * h;
            bool notAborder = yToFind == h && h * 2 > xToFind && xToFind> h;
            bool border = !notAborder&&(top && xToFind == h || xToFind == h * 2 || yToFind == 4 * h) || !notAborder&&(bot && xToFind == 0 || xToFind == h || yToFind == 0 || yToFind==3 * h);

            Console.WriteLine(top||bot?border?"border":"inside":"outside");
        }
    }
}
