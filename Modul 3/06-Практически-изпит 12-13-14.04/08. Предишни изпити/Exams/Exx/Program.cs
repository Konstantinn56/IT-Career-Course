using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exx
{
    class Program
    {
        static Dictionary<string, Coach> coaches = new Dictionary<string, Coach>();
        static Dictionary<string, Athlete> athletes = new Dictionary<string, Athlete>();


        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "AddAthlete":
                        AddAthlete(commandArgs.Skip(1).ToArray());
                        break;
                    case "PrintAthleteInfoByName":
                        PrintAthleteInfoByName(commandArgs.Skip(1).ToArray());
                        break;
                    case "AddCoach":
                        AddCoach(commandArgs.Skip(1).ToArray());
                        break;
                    case "PrintCoachInfoByName":
                        PrintCoachInfoByName(commandArgs.Skip(1).ToArray());
                        break;
                    case "AddAthleteToSpecificCoach":
                        AddAthleteToSpecificCoach(commandArgs.Skip(1).ToArray());
                        break;
                    case "RemoveAthleteFromSpecificCoach":
                        RemoveAthleteFromSpecificCoach(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetClientsCount":
                        GetClientsCount(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetAllClientsTougherThan":
                        GetAllClientsTougherThan(commandArgs.Skip(1).ToArray());
                        break;
                    case "SpendMoneyOnSupplements":
                        SpendMoneyOnSupplements(commandArgs.Skip(1).ToArray());
                        break;
                    case "TrainHard":
                        TrainHard(commandArgs.Skip(1).ToArray());
                        break;
                    case "TrainAthlete":
                        TrainAthlete(commandArgs.Skip(1).ToArray());
                        break;
                    case "RemoveAthletesLeakerThan":
                        RemoveAthletesLeakerThan(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetToughestAthlete":
                        GetToughestAthlete(commandArgs.Skip(1).ToArray());
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
        private static void AddAthlete(string[] athleteInfo)
        {
            string name = athleteInfo[0];
            int age = int.Parse(athleteInfo[1]);
            int strentgh = int.Parse(athleteInfo[2]);

            if (athletes.ContainsKey(name))
            {
                Console.WriteLine("Cannot add athlete! Athlete already exists!");
                return;
            }

            try
            {
                Athlete athlete = new Athlete(name, age, strentgh);
                athletes.Add(name, athlete);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//done
        private static void PrintAthleteInfoByName(string[] athleteInfo)
        {
            string athleteName = athleteInfo[0];

            if (!athletes.ContainsKey(athleteName))
            {
                Console.WriteLine($"Invalid athlete {athleteName}");
                return;
            }

            Console.WriteLine(athletes[athleteName].ToString());
        }//done
        private static void AddCoach(string[] coachInfo)
        {
            string name = coachInfo[0];
            int experience = int.Parse(coachInfo[1]);

            if (coaches.ContainsKey(name))
            {
                Console.WriteLine("Cannot add coach! Coach already exists!");
                return;
            }

            Coach coach;

            try
            {
                if (coachInfo.Length == 2)
                {
                    coach = new Coach(name, experience);
                }
                else
                {
                    double money = double.Parse(coachInfo[2]);
                    coach = new Coach(name, experience, money);
                }
                coaches.Add(name, coach);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//done
        private static void PrintCoachInfoByName(string[] coachInfo)
        {
            string name = coachInfo[0];

            if (!coaches.ContainsKey(name))
            {
                Console.WriteLine($"Invalid coach {name}");
                return;
            }

            Console.WriteLine(coaches[name].ToString());
        }//done
        private static void AddAthleteToSpecificCoach(string[] info)
        {
            string athleteName = info[0];
            string coachName = info[1];

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");
                return;
            }

            if (!athletes.ContainsKey(athleteName))
            {
                Console.WriteLine($"Invalid athlete {athleteName}");
                return;
            }

            Coach coach = coaches[coachName];
            Athlete athlete = athletes[athleteName];

            coach.AddNewClient(athlete);
        }//done
        private static void RemoveAthleteFromSpecificCoach(string[] info)
        {
            string athleteName = info[0];
            string coachName = info[1];

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");
                return;
            }

            if (!athletes.ContainsKey(athleteName))
            {
                Console.WriteLine($"Invalid athlete {athleteName}");
                return;
            }

            Coach coach = coaches[coachName];
            Athlete athlete = athletes[athleteName];

            bool removed = coach.LooseClient(athlete.Name);

            if (removed)
            {
                Console.WriteLine($"Successfully removed athlete: {athlete.Name} from coach {coach.Name}!");
            }
            else
            {
                Console.WriteLine($"Athlete removal failed.");
            }
        }//done
        private static void GetClientsCount(string[] info)
        {
            string coachName = info[0];

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");

                return;
            }

            Coach coach = coaches[coachName];

            int count = coach.GetClientsCount();

            Console.WriteLine($"Coach {coach.Name} has total count of clients: {count}.");
        }//done
        private static void GetAllClientsTougherThan(string[] info)
        {
            string coachName = info[0];
            int strength = int.Parse(info[1]);

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");

                return;
            }

            Coach coach = coaches[coachName];

            List<Athlete> toughGuys = coach.GetAllClientsTougherThan(strength);

            Console.WriteLine("Tough Guys:");

            for (int i = 0; i < toughGuys.Count; i++)
            {
                Console.WriteLine($"{i}: {toughGuys[i]}");
            }
        }//done
        private static void SpendMoneyOnSupplements(string[] info)
        {
            string coachName = info[0];
            double money = double.Parse(info[1]);

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");
                return;
            }

            Coach coach = coaches[coachName];
            try
            {
                coach.SpendMoneyOnSupplements(money);
                Console.WriteLine($"Coach {coachName} spent on supplements {money:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//done
        private static void TrainHard(string[] info)
        {
            string coachName = info[0];

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");

                return;
            }

            Coach coach = coaches[coachName];

            coach.TrainHard();
        }//done
        private static void TrainAthlete(string[] info)
        {
            string athleteName = info[0];
            string coachName = info[1];

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");

                return;
            }

            if (!athletes.ContainsKey(athleteName))
            {
                Console.WriteLine($"Invalid athlete {athleteName}");

                return;
            }

            Coach coach = coaches[coachName];
            Athlete athlete = athletes[athleteName];

            coach.TrainClient(athlete);
        }//done
        private static void RemoveAthletesLeakerThan(string[] info)
        {
            string coachName = info[0];
            int strength = int.Parse(info[1]);

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");

                return;
            }

            Coach coach = coaches[coachName];

            int loosers = coach.RemoveAllClientsLeakerThan(strength);

            Console.WriteLine($"Coach {coach.Name} removed {loosers} loosers.");
        }//done
        private static void GetToughestAthlete(string[] info)
        {
            string coachName = info[0];

            if (!coaches.ContainsKey(coachName))
            {
                Console.WriteLine($"Invalid coach {coachName}");

                return;
            }

            Coach coach = coaches[coachName];

            Athlete toughest = coach.GetToughestClient();

            Console.WriteLine($"Toughest client of coach {coach.Name} is {toughest.ToString()}");
        }//done
    }
}
