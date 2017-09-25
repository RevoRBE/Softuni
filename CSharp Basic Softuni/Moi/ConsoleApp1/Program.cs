using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = "";
            while (stop!="stop")
            {
                string d = Console.ReadLine();
                string m = Console.ReadLine();
                d = d.Length < 2 ? "0" + d : d;
                m = m.Length < 2 ? "0" + m : m;
                string prepDate = d + '-' + m;
                DateTime date = DateTime.ParseExact(prepDate, "dd-MM", null);
                //DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM", null);
                Console.WriteLine(date.AddDays(5).ToString("dd-MM"));
                stop = Console.ReadLine();
            }
        }
    }
}
