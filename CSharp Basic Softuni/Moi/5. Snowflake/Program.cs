using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < n - 1; i++)
        {
            builder.Append
                (string.Concat(Enumerable.Repeat('.', i)) + '*' +
                string.Concat(Enumerable.Repeat('.', n - i)) + '*' +
                string.Concat(Enumerable.Repeat('.', n - i)) + '*' +
                string.Concat(Enumerable.Repeat('.', i)))
                .AppendLine();
        }
        builder.Append(string.Concat(Enumerable.Repeat('.', n - 1)) + "*****" + string.Concat(Enumerable.Repeat('.', n - 1))).AppendLine()
        .Append(string.Concat(Enumerable.Repeat('*', n * 2 + 3))).AppendLine()
        .Append(string.Concat(Enumerable.Repeat('.', n - 1)) + "*****" + (string.Concat(Enumerable.Repeat('.', n - 1)))).AppendLine();
        for (int i = n - 2; i >= 0; i--)
        {
            builder.Append
                (string.Concat(Enumerable.Repeat('.', i)) + '*' +
                string.Concat(Enumerable.Repeat('.', n - i)) + '*' +
                string.Concat(Enumerable.Repeat('.', n - i)) + '*' +
                string.Concat(Enumerable.Repeat('.', i)))
                .AppendLine();
        }
        string str = builder.ToString();
        Console.WriteLine(str);
    }
}