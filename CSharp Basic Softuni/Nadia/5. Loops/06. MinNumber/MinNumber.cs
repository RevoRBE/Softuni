using System;


namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            int minnumber = int.MaxValue;

            for (int i = 0; i < lenght; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minnumber)
                {
                    minnumber = num;
                }
            }
            Console.WriteLine(minnumber);
        }
    }
}

