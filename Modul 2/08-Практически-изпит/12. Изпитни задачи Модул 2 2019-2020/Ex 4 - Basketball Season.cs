using System;
using System.Collections.Generic;
using System.Linq;

namespace oijoj
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> playerNameAndPoints = new SortedDictionary<string, int>();
            char[] charSeparators = new char[] {' ', '-'};
            string[] commandLine = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (!commandLine[0].Equals("END"))
            {
                string name = commandLine[0];
                int points = int.Parse(commandLine[1]);
                if (!playerNameAndPoints.ContainsKey(name))
                {
                    playerNameAndPoints.Add(name, 0);
                }
                playerNameAndPoints[name] += points;

                commandLine = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var player in playerNameAndPoints)
            {
                Console.WriteLine($"{player.Key} -> {player.Value}");
            }
        }
    }
}
