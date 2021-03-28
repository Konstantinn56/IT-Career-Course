using System;
using System.Collections.Generic;
using System.Linq;

namespace adfgg
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> db = new SortedDictionary<string, List<string>>();

            string[] commands = Console.ReadLine().Split();
            
            while (!commands[0].Equals("End"))
            {
                switch (commands[0])
                {
                    case "Add":
                        string country = commands[1];
                        string city = commands[2];
                        if (!db.ContainsKey(country))
                        {
                            db.Add(country, new List<string>());
                        }
                        db[country].Add(city);
                        break;
                    
                    case "Remove":
                        bool isFound = false;
                        foreach (var kvp in db)
                        {
                            foreach (var c in kvp.Value)
                            {
                                if (c.Equals(commands[1]))
                                {
                                    kvp.Value.Remove(c);
                                    isFound = true;
                                    break;
                                }
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine($"City{commands[1]} not found");
                        }   
                        break;
                    
                    default:
                        break;
                }

                commands = Console.ReadLine().Split();
            }
            var sorted = db.OrderByDescending(t => t.Value.Count)
                .ThenBy(c => c.Key);

            foreach (var kvp in sorted)
            {
                Console.Write($"{kvp.Key} has {kvp.Value.Count} cities and they are: ");
                Console.WriteLine(string.Join(", ", kvp.Value));
            }
                
        }
    }
}
