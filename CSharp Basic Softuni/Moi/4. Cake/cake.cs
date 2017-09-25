using System;

class cake
{
    static void Main()
    {
        int shiro = int.Parse(Console.ReadLine());
        int dylji = int.Parse(Console.ReadLine());
        var size = shiro * dylji;
        string input = "";
        var pw = 0;
        while (input != "STOP" && pw <= size)
        {
            int temp = 0;
            input = Console.ReadLine();
            int.TryParse(input, out temp);
            pw += temp;
        }
        if (pw >= size)
        {
            Console.WriteLine("No more cake left! You need {0} pieces more.", pw - size);
        }
        else
        {
            Console.WriteLine("{0} pieces are left.", size - pw);
        }
    }
}