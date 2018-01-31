using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SliceFile
{
    private const int bufferSize = 4096;
    static void Main()
    {
        string sourceFile = "../Resources/SliceMe.mp4";
        string destination = "";
        int parts = 5;
        Slice(sourceFile, destination, parts);
        var files = new List<string>
        {
            "Part-0.mp4",
            "Part-1.mp4",
            "Part-2.mp4",
            "Part-3.mp4",
            "Part-4.mp4",
        };
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (FileStream reader = new FileStream(sourceFile, FileMode.Open))
        {
            string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);
            long pieceSize = (long)Math.Ceiling((double)reader.Length / parts);
            for (int i = 0; i < parts; i++)
            {
                long currentPieceSize = 0;
                destinationDirectory = destinationDirectory == String.Empty ? "./" : destinationDirectory;
                string currentPart = destinationDirectory + $"Part-{i}.{extension}";
                using (FileStream writer = new FileStream(destinationDirectory, FileMode.Create))
                {
                    byte[] buffer = new byte[bufferSize];
                    while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                    {
                        writer.Write(buffer, 0, bufferSize);
                        if (currentPieceSize >= pieceSize)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

    static void Join(List<string> files, string destinationDirectory)
    {
        string extension = files[0].Substring(files[0].LastIndexOf('.') + 1);
        destinationDirectory = destinationDirectory == String.Empty ? "./" : destinationDirectory;
        destinationDirectory = !destinationDirectory.EndsWith("/") ? destinationDirectory += "/": destinationDirectory;
        string file = $"{destinationDirectory}File.{extension};"

    }
}
