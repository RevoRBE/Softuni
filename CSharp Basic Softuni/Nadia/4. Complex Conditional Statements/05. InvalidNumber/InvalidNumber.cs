using System;


namespace _05.InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            bool isValid = (num >= 100 && num <= 200) || num == 0;
            Console.WriteLine( !isValid?"invalid":"");          
        }
    }
}
