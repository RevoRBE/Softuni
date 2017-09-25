using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char special = '#';
            string temp = "";
            int lineLenght = n * 5;
            

            for (int i = 0; i < n + 1; i++) /*6 ......###### ###### ######......*/
            {
                if (i >= n / 2) special = '.';
                temp = String.Format("{0}#{1}#{0}", new string('.', n + i), new string(special, 3 * n - i * 2 - 2));
                Console.WriteLine(temp);
            }
            temp = String.Format("{0}{1}{0}", new string('.', n * 2), new string('#', n));
            Console.WriteLine(temp);
            for (int i = 0; i < n + 1; i++)
            {
                if (i == n / 2) Console.WriteLine(new string ('.',(n*5-10)/2)+"D^A^N^C^E^"+new string('.', (n * 5 - 10) / 2));
                temp = String.Format("{0}{1}{0}", new string('.', n * 2 - 2), new string('#', lineLenght - 2*(n*2-2)));
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
