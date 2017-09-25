using System;


namespace _12.Butterfly
{
    class Butterfly
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int down = 1; down <= n - 2; down++)
            {
                if (down % 2 == 0)
                {
                    Console.WriteLine(@"{0}\ /{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine(@"{0}\ /{0}", new string('*', n - 2));

                }
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
            for (int down = 1; down <= n - 2; down++)
            {
                if (down % 2 == 0)
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('*', n - 2));

                }
            }
        }
    }
}
