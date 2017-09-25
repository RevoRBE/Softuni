using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class bullshit
{
    static void Main()
    {
        var str = new StringBuilder();
        for (int col = 0; col < 10; col++)
        {
            str.Append(new string('*', 10)).AppendLine();
        }
        Console.Write(str);
    }
}