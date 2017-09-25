using System;

class scholarship
{
    static void Main()
    {
        double income = double.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());
        double minimal = double.Parse(Console.ReadLine());
        double social = 0;
        double excelent = 0;

        if (grade > 4.5 && income < minimal)
        {
            social = 0.35 * minimal;
        }
        if (grade >= 5.5) excelent = grade * 25;
        if(social==0&&excelent==0) Console.WriteLine($"You cannot get a scholarship!");
        else if (excelent >= social && excelent != 0)
        {
            Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelent)} BGN");
        }
        else if (excelent < social)
        {
            Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
        }
    }
}