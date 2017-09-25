using System;


namespace _11.EqualWords
{
    class EqualWords
    {
        static void Main()
        {
            string firstWord = Console.ReadLine();
            string firstWordToLower = firstWord.ToLower();
            string secondWord = Console.ReadLine();
            string secondWordToLower = secondWord.ToLower();

            if (firstWordToLower == secondWordToLower)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
