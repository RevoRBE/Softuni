using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class easy
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var fig = new StringBuilder();
        for (int col = 0; col < num; col++)
        {
            fig.Append(new string('*', num)).AppendLine();
        }
        Console.Write(fig.ToString());
    }
}