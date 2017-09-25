using System;


namespace _14.StopSign2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var underscopes = 2 * n + 1;
            var dots = n + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underscopes));
            underscopes -= 2;
            for (int i = 0; i < n; i++)
            {
                dots--;
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', dots), new string('_', underscopes));
                underscopes = underscopes + 2;
            }
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', (underscopes - 5) / 2));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', i), new string('_', underscopes - 2 * i));
            }
        }
    }
}

