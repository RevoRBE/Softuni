using System;


namespace _11.DrawFort
{
    class DrawFort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //First Line
            Console.WriteLine("/"+ new string('^', n / 2) + @"\"
                + new string('_', n - 2 - (n / 2)) + new string('_', n - 2 - (n / 2))
                + "/" + new string('^', n / 2) + @"\");

            for (int down = 1; down <= n - 3; down++)
            {
                Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|");
            }
            Console.WriteLine("|" + new string(' ', (n / 2) + 1)
                + new string('_', n - 2 - (n / 2)) + new string('_', n - 2 - (n / 2))
                + new string(' ', (n / 2) + 1) + "|");
            //Last Line
            Console.WriteLine(@"\" + new string('_', n / 2) + "/"
                + new string(' ', n - 2 - (n / 2)) + new string(' ', n - 2 - (n / 2))
                + @"\" + new string('_', n / 2) + @"/");
        }
    }
}
