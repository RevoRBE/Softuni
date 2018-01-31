﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Simple_Text_Editor
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Stack<string> undo = new Stack<string>();
        string text = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (commands[0])
            {
                case "1":
                    undo.Push(text);
                    text += commands[1];
                    break;
                case "2":
                    undo.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(commands[1]));
                    break;
                case "3":
                    Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                    break;
                case "4":
                    text = undo.Pop();
                    break;
            }
        }
    }
}