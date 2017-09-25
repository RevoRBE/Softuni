using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class messages
{
    static void Main(string[] args)
    {
        string c1 = Console.ReadLine();
        string s = Console.ReadLine();
        string c2 = Console.ReadLine();
        string[] c1a = Cut3(c1);
        string[] c2a = Cut3(c2);
        int n1 = Conv(c1a);
        int n2 = Conv(c2a);
        Console.WriteLine(Conv(n1-n2));

    }

    private static string[] Cut3(string str)
    {
        string[] output = new string[str.Length / 3];
        for (int i = 0, j = 0; i < str.Length / 3; i++, j += 3)
        {
            output[i] = str.Substring(j, 3);
        }
        return output;
    }
    private static int Conv(string[] str)
    {
        int output = 0;
        string[] dec = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
        for (int i = 0; i < str.Length; i++)
        {
            output = output*10 + Array.IndexOf(dec, str[i]);
        }
        return output;
    }
    private static string Conv(int num)
    {
        int[] digits = num.ToString().Select(x => int.Parse(x.ToString())).ToArray();
        string output = "";
        string[] dec = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
        for (int i = 0; i < num.ToString().Length; i++)
        {
            output += dec[digits[i]];
        }
        return output;
    }
}