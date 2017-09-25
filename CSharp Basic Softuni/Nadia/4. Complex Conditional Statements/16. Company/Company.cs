using System;


namespace _16.Company
{
    class Company
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employeesEx = int.Parse(Console.ReadLine());

            double workHours = (days - (days * 0.1)) * 8;
            double overtime = employeesEx * days * 2;
            double totalHours = Math.Floor(workHours + overtime);

            if (totalHours >= hours)
            {
                double leftHours = totalHours - hours;
                Console.WriteLine("Yes!{0} hours left.", leftHours);
            }
            else
            {
                double neededHours = hours - totalHours;
                Console.WriteLine("Not enough time!{0} hours needed.", neededHours);
            }
        }
    }
}
