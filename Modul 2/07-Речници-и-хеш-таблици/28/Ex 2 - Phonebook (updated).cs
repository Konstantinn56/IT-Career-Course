using System;
using System.Collections.Generic;

namespace dsfgg
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string[] currentCommand = Console.ReadLine().Split();
            while (!currentCommand[0].Equals("END"))
            {
                switch (currentCommand[0])
                {
                    case "A":
                        if (!phonebook.ContainsKey(currentCommand[1]))
                        {
                            phonebook.Add(currentCommand[1], currentCommand[2]);
                        }
                        else
                        {
                            phonebook[currentCommand[1]] = currentCommand[2];
                        }
                        break;

                    case "S":
                        if (!phonebook.ContainsKey(currentCommand[1]))
                        {
                            Console.WriteLine($"Contact {currentCommand[1]} does not exist.");
                        }
                        else
                        {
                            foreach (var n in phonebook)
                            {
                                if (n.Key.Equals(currentCommand[1]))
                                {
                                    Console.WriteLine($"{n.Key} -> {n.Value}");
                                }
                            }

                        }
                        break;

                    case "ListAll":
                        foreach (var n in phonebook)
                        {
                            Console.WriteLine($"{n.Key} -> {n.Value}");
                        }
                        break;

                    default:
                        break;
                }
                currentCommand = Console.ReadLine().Split();
            }
        }
    }
}
