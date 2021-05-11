using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Team team = new Team("Zvezdichka");
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();

                Person person = new Person(info[0], info[1], int.Parse(info[2]), double.Parse(info[3]));
                team.AddPlayer(person);
            }
            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"First team have {team.ReserveTeam.Count} players");
        }
    }
}
