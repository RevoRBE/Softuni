using System;
using System.Linq;
using System.Text;

class Rocket
{
    static void Main()
    {
        drawRocket(int.Parse(Console.ReadLine()));

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("Press any key to exit Ive :P");
        Console.ReadLine();
    }

    private static void drawRocket(int length)
    {
        var sb = new StringBuilder();

        drawHead(sb, length);
        drawRing(sb, length);
        drawUpBody(sb, length);
        drawDownBody(sb, length);
        drawRing(sb, length);
        drawDownBody(sb, length);
        drawUpBody(sb, length);
        drawRing(sb, length);

        Console.Write(sb.ToString());

        drawTail(sb, length);
    }

    private static void drawHead(StringBuilder sb, int length)
    {
        sb.AppendLine(new String(' ', length * 2 - 1) + @"/**\");
        for (int i = 1; i < length; i++)
        {
            sb.AppendLine(
                new string(' ', (length - i) * 2) +
                new string('/', i * 2) + "**" +
                new string('\\', i * 2));

            sb.AppendLine(
                new string(' ', ((length - i) * 2) - 1) +
                new string('/', i * 2 + 1) + "**" +
                new string('\\', i * 2 + 1));
        }
    }

    private static void drawRing(StringBuilder sb, int length)
    {
        sb.Append('+');
        for (int i = 0; i < length * 2; i++)
        {
            sb.Append("*=");
        }
        sb.Append('+');
        sb.AppendLine();
    }

    private static void drawUpBody(StringBuilder sb, int length)
    {
        for (int i = 0; i < length; i++)
        {
            sb.AppendLine('|' +
                new string('.', length - 1 - i) +
                string.Concat(Enumerable.Repeat("/\\", i + 1)) +
                new string('.', (length - 1 - i) * 2) +
                string.Concat(Enumerable.Repeat("/\\", i + 1)) +
                new string('.', length - 1 - i) +
                '|');
        }
    }

    private static void drawDownBody(StringBuilder sb, int length)
    {
        for (int i = length; i > 0; i--)
        {
            sb.AppendLine('|' +
                new string('.', length - i) +
                string.Concat(Enumerable.Repeat("\\/", i)) +
                new string('.', (length - i) * 2) +
                string.Concat(Enumerable.Repeat("\\/", i)) +
                new string('.', length - i) +
                '|');
        }
    }

    private static void drawTail(StringBuilder sb, int length)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(new String(' ', length * 2 - 1) + @"/**\");

        for (int i = 1; i < length; i++)
        {
            if (1 == length-i)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            Console.WriteLine(
                new string(' ', (length - i) * 2) +
                new string('/', i * 2) + "**" +
                new string('\\', i * 2));
            if (i == length-1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(
                new string(' ', ((length - i) * 2) - 1) +
                new string('/', i * 2 + 1) + "**" +
                new string('\\', i * 2 + 1));
        }
    }
}
