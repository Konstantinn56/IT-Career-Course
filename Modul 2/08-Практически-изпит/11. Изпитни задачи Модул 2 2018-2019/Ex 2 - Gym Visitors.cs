using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace opk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = Console.ReadLine().Split().ToList();
            //Ivan, Peter, Simona, Krasimir, Petya

            string[] firstCommand = new string[1];

            while(firstCommand[0] != "END")
            {
                firstCommand[0] = Console.ReadLine();
                string[] secondCommand = new string[3];
                switch (firstCommand[0])
                {
                    case "Add visitor":
                        secondCommand[0] = Console.ReadLine();
                        visitors.Add(secondCommand[0]);
                        break; 

                    case "Add visitor on position":
                        secondCommand[0] = Console.ReadLine();//name
                        secondCommand[1] = Console.ReadLine();//position
                        visitors.Insert(Int32.Parse(secondCommand[1]), secondCommand[0]);
                        break;

                    case "Remove visitor on position":
                        secondCommand[0] = Console.ReadLine();//position
                        visitors.RemoveAt(Int32.Parse(secondCommand[0]));
                        break;

                    case "Remove last visitor":
                        visitors.RemoveAt(visitors.Count - 1);
                        break;
                    
                    case "Remove first visitor":
                        visitors.RemoveAt(0);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",visitors));
        }

    }
}
