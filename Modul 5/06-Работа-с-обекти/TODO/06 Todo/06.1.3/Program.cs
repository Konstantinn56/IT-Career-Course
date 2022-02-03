using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._1._3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<int> li = new ListyIterator<int>();
            int[] elements = new int[] { 1, 2,3 ,4 ,5};
            li.Create(elements);

            string commandLine = Console.ReadLine();
            while (!commandLine.Equals("END"))
            {
                switch (commandLine)
                {
                    case"Move":
                        {
                            Console.WriteLine(li.Move());
                            break;
                        }
                    case "Print":
                        {
                            li.Print();
                            break;
                        }
                    case "HasNext":
                        {
                            Console.WriteLine(li.HasNext());
                            break;
                        }
                    case "PrintAll":
                        {
                            li.PrintAll();
                            break;
                        }
                }
                commandLine = Console.ReadLine();
            }
            
        }
    }
}