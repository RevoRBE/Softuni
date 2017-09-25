using System;


namespace _09.PasswordGuess
{
    class PasswordGuess
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string secretPass = "s3cr3t!P@ssw0rd";

            if (text == secretPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
