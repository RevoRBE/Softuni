using System;

class Bonus_conditions
{
    static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
        double bonus = 0;
        if (num <=100)
        {
            bonus += 5;
        }
        else if (num >1000)
        {
            bonus += (num * 0.1);
        }
        else if (num > 100)
        {
            bonus += (num * 0.2);
        }
        if (num %2==0)
        {
            bonus += 1;
        }
        else if (num%10==5)
        {
            bonus += 2;
        }
        Console.WriteLine("{0}\n{1}", bonus, num+bonus);
    }
}