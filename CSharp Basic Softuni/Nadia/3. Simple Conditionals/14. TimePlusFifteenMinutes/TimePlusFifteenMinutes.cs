using System;

class Program
{
    static void Main(string[] args)
    {

        int[] time = new int[2];
        for (int i = 0; i < 2; i++)
        {
            time[i] = int.Parse(Console.ReadLine());
        }
        time[1] += 15;
        if (time[1] > 59)
        {
            time[0]++; time[1] -= 60;
        }
        if (time[0] > 23) time[0] -= 24;
        Console.WriteLine("{0}:{1:D2}", time[0], time[1]);
    }
}