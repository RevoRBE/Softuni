using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_and_Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher*/
            string input = Console.ReadLine();
            var list = new List<int>();
            for (int i = input.Length-1; i >= 0; i--)
            {
                if (Char.IsDigit(input[i]))
                {
                    list.Add(input[i] - '0');
                }
                else break;
            }
            list.Reverse();
            string tempcypher = string.Join("", list.ToArray());
            list.Clear();
            int cypherLengthMeta = tempcypher.Length;
            int cypherLength = int.Parse(tempcypher);
            string encoded = input.Substring(0, input.Length - cypherLengthMeta);
            int repeater = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
            {
                if (Char.IsDigit(encoded[i]))
                {
                    repeater = repeater*10+ int.Parse(encoded[i].ToString());
                    repeater = int.Parse(encoded[i].ToString());
                }
                else
                {
                    sb.Append(encoded[i], repeater);
                    repeater = 1;
                }
            }
            string decoded = sb.ToString();
            string message = decoded.Substring(0, decoded.Length - cypherLength);
            string cypher = decoded.Substring(decoded.Length - cypherLength, cypherLength);
            int steps = Math.Max(message.Length, cypherLength);
            sb.Clear();
            sb.Append(message);
            for (int i = 0; i < steps; i++)
            {
                var messageIndex = i % message.Length;
                var cypherIndex = i % cypher.Length;
                sb[messageIndex] = (char)(((sb[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) +'A'); //(sb[messageIndex] ^ cypher[cypherIndex]);
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        //private static string Decode(string coded)
        //{
        //    char prev = coded[0];
        //    char[] charrr= coded.ToArray();
        //    int counter = 0;
        //    foreach (char ch in coded.Skip(1))
        //    {
        //        //if (ch = prev)
        //        //{

        //        //}
        //        //char prev = ch;

        //    }

        //    return coded;
        //}

        //private static string Decrypt(string crypted, string cypher)
        //{
        //    int length = crypted.Length < cypher.Length ? crypted.Length : cypher.Length;
        //    StringBuilder output = new StringBuilder();
        //    for (int i = 0,y=0; i < length; i++, y++)
        //    {
        //        output.Append(crypted[i] ^ cypher[y]);
        //        //if
        //    }
        //    return output.ToString();
        //}
    }
}
