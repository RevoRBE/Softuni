using System;


namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main()
        {
            //try - catch: Exception = Error
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("This is the number : {0}", num);
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);                
                }                                        
            }
        }
    }
}
