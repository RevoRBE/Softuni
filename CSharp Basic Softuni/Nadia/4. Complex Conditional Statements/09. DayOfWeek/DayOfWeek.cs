using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string[] weekdays = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            Console.WriteLine(weekdays.ElementAtOrDefault(num - 1) != null ? weekdays[num - 1] : "error");
        }
    }
}
