using System;
using System.Collections.Generic;
using System.Linq;

namespace _102
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var source = "../../../video.mp4";
            var destination = "../../../";
            int parts = 3;

            Console.WriteLine($"Source: {source}");
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Parts: {parts}");

            List<string> files = Slice(source,destination,parts);
            Console.WriteLine($"Sliced!");

            Assemble(files, destination);
            Console.WriteLine("Assembled!");

        }
        public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            var files = new List<string>();

            var reversed = new string(sourceFile.Reverse().ToArray());
            string extension = new string(reversed.Substring(0, reversed.IndexOf('.')).Reverse().ToArray());//extension mp4

            using (FileStream read = new FileStream(sourceFile , FileMode.Open))
            {
                int fileLength = (int)read.Length;
                int sizeOfFile = fileLength / parts;

                for (int i = 0; i < parts; i++)
                {
                    var fileName = $"part_{i + 1}.{extension}";
                    files.Add(fileName);

                    using (FileStream write = new FileStream($"{destinationDirectory}/{fileName}", FileMode.Create))
                    {
                        byte[] bytes = new byte[sizeOfFile];
                        int data = read.Read(bytes , 0 , bytes.Length);
                        write.Write(bytes, 0, bytes.Length);
                    }
                }
            }

            return files;
        }
        public static void Assemble(List<string> files , string destinationDirectory)
        {
            string extension = files[0].Substring(files[0].IndexOf('.') + 1);
            using (FileStream write = new FileStream($"{destinationDirectory}/assenbled.{extension}" , FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (FileStream read = new FileStream($"{destinationDirectory}/{file}", FileMode.Open))
                    {
                        byte[] bytes = new byte[4096];
                        while (true)
                        {
                            int bytesRead = read.Read(bytes , 0 , bytes.Length);
                            if(bytesRead == 0)
                            {
                                break;
                            }
                            write.Write(bytes, 0, bytes.Length);
                        }
                    }
                    
                }
            }
        }
    }
}