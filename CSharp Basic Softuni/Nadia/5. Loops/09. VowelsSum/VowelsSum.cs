using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            char[] vowels= { 'b', 'a', 'e', 'i', 'o', 'u' };

            int sum = 0;

            foreach (char vowel in input)
            {
                if (vowels.Contains(vowel))
                {
                    sum += Array.IndexOf(vowels, vowel);
                }
            }
            Console.WriteLine(sum);

            //for (int i = 0; i <= input.Length - 1; i++)
            //{
            //    char currentChar = input[i];
            //    if (currentChar == 'a')
            //    {
            //        sum++;
            //    }
            //    else if (currentChar == 'e')
            //    {
            //        sum += 2;
            //    }
            //    else if (currentChar == 'i')
            //    {
            //        sum += 3;
            //    }
            //    else if (currentChar == 'o')
            //    {
            //        sum += 4;
            //    }
            //    else if (currentChar == 'u')
            //    {
            //        sum += 5;
            //    }
            //}
        }
    }
}
