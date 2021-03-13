using System;
using System.Text;

namespace dgbh
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            //That is not true.

            string[] command = Console.ReadLine().Split();
            //Remove 8 3

            switch (command[0])
            {
                case "Remove":
                    int index = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    text = text.Remove(index , length);
                    break;
                
                case "Append":
                    text = text.Append(command[1]);
                    break;
                
                case "Insert":
                    int indexx = int.Parse(command[1]);
                    text = text.Insert(indexx, command[2]);
                    break;
                
                case "Replace":
                    text = text.Replace(command[1], command[2]);
                    break;
            }
            Console.WriteLine(text);
        }
    }
}
