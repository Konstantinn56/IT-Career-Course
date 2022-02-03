using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Controller
    {
        private List<Village> villages;
        private List<Rebel> rebels;
        private int attacks;
        public Controller()
        {
            this.villages = new List<Village>();
            this.rebels = new List<Rebel>();
        }
        public string ProceseVillageCommand(List<string> args)
        {
            //name,loaction
            Village village = new Village(args[0], args[1]);
            this.villages.Add(village);
            return $"Created Village {village.Name}!";
        }

        public string ProcessSettleCommand(List<string> args)
        {
            //name,age,productivity,villageName
            string villageName = args[3];
            Peasant peasant = new Peasant(args[0], int.Parse(args[1]), int.Parse(args[2]));
            Village village = GetVillage(villageName);
            village.AddPeasant(peasant);
            return $"Settled Peasant {peasant.Name} in Village {villageName}!";
        }
        public string ProcessRebelCommand(List<string> args)
        {
            //name,age,harm
            Rebel rebel = new Rebel(args[0], int.Parse(args[1]), int.Parse(args[2]));
            this.rebels.Add(rebel);
            return $"Rebel {rebel.Name} joined the gang!";
        }
        public string ProcessDayCommand(List<string> args)
        {
            //villageName
            Village village = GetVillage(args[0]);
            int resource = village.PassDay();
            return $"Village {village.Name} resource increased with {resource}!";
        }
        public string ProcessAttackCommand(List<string> args)
        {
            //rebelCount, villageName
            int rebelCount = int.Parse(args[0]);
            string villageName = args[1];
            if (this.rebels.Count != 0)
            {
                List<Rebel> currentRebels = this.rebels.Take(rebelCount).ToList();
                Village currentVillage = GetVillage(villageName);
                int harm = GetHarm(currentRebels);
                currentVillage.Attack(harm);
                currentVillage.KillPeasants(currentRebels.Count / 2);
                this.attacks++;
                return $"Village {villageName} lost {harm} resources and {currentRebels.Count / 2} peasants!";
            }
            return "No rebels to perform raid...";

        }
        public string ProcessInfoCommand(List<string> args)
        {
            //side
            StringBuilder sb = new StringBuilder();
            string side = args[0];
            switch (side)
            {
                case "Rebel":
                    {
                        if (this.rebels.Count == 0)
                        {
                            sb.AppendLine("No Rebels");
                            break;
                        }
                        sb.AppendLine("Rebels:");
                        foreach (Rebel r in this.rebels)
                        {
                            sb.AppendLine(r.ToString());
                        }
                        break;
                    }
                case "Village":
                    {
                        if (this.villages.Count == 0)
                        {
                            sb.AppendLine("No Villages");
                            break;
                        }
                        sb.AppendLine("Villages:");
                        foreach (Village v in this.villages)
                        {
                            sb.AppendLine(v.ToString());
                        }
                        break;
                    }
            }
            return sb.ToString();
        }
        public string ProcessEndCommand()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Villages: {this.villages.Count}");
            sb.AppendLine($"Rebels: {this.rebels.Count}");
            sb.AppendLine($"Attacks on Villages: {this.attacks}");
            return sb.ToString().Trim();
        }
        public Village GetVillage(string name)
        {
            return this.villages.Where(v => v.Name.Equals(name)).FirstOrDefault();
        }
        public int GetHarm(List<Rebel> rebels)
        {
            int rebelsHarm = 0;
            foreach (Rebel r in rebels)
            {
                rebelsHarm += r.Harm;
            }
            return rebelsHarm;
        }
    }
}

