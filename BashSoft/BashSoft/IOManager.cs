﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                //TODO: Dequeue the folder at the start of the queue
                var currentPath = subFolders.Dequeue();
                var identation = currentPath.Split('\\').Length - initialIdentation;

                //TODO: Print the folder path
                OutputWriter.WriteMessageOnNewLine($"{new string('-', identation)}{currentPath}");


                foreach (var directoryPath in Directory.GetDirectories(currentPath))
                {
                    //TODO: Add all it's subfolders to the end of the queue
                    subFolders.Enqueue(directoryPath);
                }
            }
        }
    }
}
