using BrokerCompanySystem.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem
{
    class CompanyController
    {
        private List<Company> companies = new List<Company>();
        public string CreateCompany(List<string> args)
        {
            //[0]Deager
            Company company = this.GetCompanyByName(args[0]);
            if (company == null)
            {
                company = new Company(args[0]);
                this.companies.Add(company);
                return $"Company {company.Name} was successfully registerd in the system!";
            }

            return $"Company {company.Name} is already registered!";
        }

        public string RegisterBuilding(List<string> args)
        {
            //RegisterBuilding*Hotel*Sun Hotel*Sofia*4*50000*Deager
            //Hotel*Sun Hotel*Sofia*4*50000*Deager
            Building building = null;
            switch (args[0])
            {
                case "Hotel":
                    building = new Hotel(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
                case "Residence":
                    building = new Residence(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
                case "Business":
                    building = new Business(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
            }
            Company company = this.GetCompanyByName(args[5]);
            if (company == null)
            {
                return $"Invalid Company: {args[5]}. Cannot find it in system!";
            }

            if (company.GetBuildingByName(args[1]) != null)
            {
                return $"Building {args[1]} is already registered in {company.Name}!";
            }

            company.AddBuilding(building);

            return $"Building {building.Name} was successfully registerd in {company.Name} catalog!";
        }

        private Company GetCompanyByName(string name)
        {
            return this.companies.Where(c => c.Name.Equals(name)).FirstOrDefault();
        }
        public string RegisterBroker(List<string> args)
        {
            //RegisterBroker*Sade*35*Plovdiv*Deager
            //Sade*35*Plovdiv*Deager
            Broker broker = new Broker(args[0], int.Parse(args[1]), args[2]);
            Company company = this.GetCompanyByName(args[3]);
            if (company == null)
            {
                return $"Invalid Company: {args[3]}. Cannot find it in system!";
            }

            if (company.GetBrokerByName(args[0]) != null)
            {
                return $"Broker {args[0]} is already part of {args[3]}!";
            }

            company.AddBroker(broker);
            return $"Broker {broker.Name} was successfully hired in {company.Name}!";
        }

        public string RentBuilding(List<string> args)
        {
            //RentBuilding*Deager*Heaven Business*Sade
            //Deager*Heaven Business*Sade
            Company company = this.GetCompanyByName(args[0]);
            if (company != null)
            {
                Building building = company.GetBuildingByName(args[1]);
                Broker broker = company.GetBrokerByName(args[2]);
                if (building != null)
                {
                    if (!building.IsAvailable)
                    {
                        return $"Building: {building.Name} cannot be rented!";
                    }
                    if (broker != null)
                    {
                        building.IsAvailable = false;
                        double bonus = broker.ReceiveBonus(building);
                        return $"Successfully rented {building.Name}! " +
                            $"{Environment.NewLine}Broker {broker.Name} earned {bonus}!";
                    }
                    return $"Invalid Broker: {args[2]}. Cannot find employee in {args[0]}!";
                }

                return $"Invalid Building: {args[1]}. Cannot find it in {args[0]} catalog!";
            }
            return $"Invalid Company: {args[0]}. Cannot find it in system!";
        }

        public string CompanyInfo(List<string> args)
        {
            Company company = this.GetCompanyByName(args[0]);
            if (company == null)
            {
                return $"Invalid Company: {args[0]}. Cannot find it in system!";
            }
            return company.ToString();
        }

        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Companies: {companies.Count}");
            foreach (var company in this.companies.OrderBy(c => c.Name))
            {
                sb.AppendLine(company.ToString());
            }

            return sb.ToString();
        }

    }
}
