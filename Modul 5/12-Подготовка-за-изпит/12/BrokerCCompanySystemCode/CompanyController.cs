using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCCompanySystemCode
{
    public class CompanyController
    {
        private List<Company> companies = new List<Company>();
        public string CreateCompany(List<string> args)
        {
            Company company = new Company(args[0]);
            companies.Add(company);
            return $"Company {company.Name} was successfully registerd in the system!";
        }

        public string RegisterBuilding(List<string> args)
        {
            Building build = null;
            switch (args[0])
            {
                case "Hotel":
                    {
                        build = new Hotel(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                        break;
                    }
                case "Business":
                    {
                        build = new Business(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                        break;
                    }
                case "Residence":
                    {
                        build = new Residence(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                        break;
                    }
            }
            Company company = GetCompanyByName(args[5]);
            if(company == null)
            {
                return $"Invalid Company: {args[5]}. Cannot find it in system!";
            }
            if(company.GetBuildingByName(args[1]) != null)
            {
                return $"Building {args[1]} is already registered in {company.Name}!";
            }

            company.AddBuilding(build);
            return $"Building {build.Name} was successfully registerd in {company.Name} catalog!";
        }
        public Company GetCompanyByName(string args)
        {
            return companies.Where(n => n.Name.Equals(args)).FirstOrDefault();
        }
        public string RegisterBroker(List<string> args)
        {
            //Sade*35*Plovdiv*Deager
            Broker broker = new Broker(args[0], int.Parse(args[1]), args[2]);
            Company company = GetCompanyByName(args[3]);
            if(company == null)
            {
                return $"Invalid Company: {args[3]}. Cannot find it in system!";
            }
            if(company.GetBrokerByName(broker.Name) != null)
            {
                return $"Broker {args[0]} is already part of {args[3]}!";
            }
            company.AddBroker(broker);
            return $"Broker {broker.Name} was successfully hired in {company.Name}!";
        }

        public string RentBuilding(List<string> args)
        {
            //Deager*Heaven Business*Sade
            Company company = GetCompanyByName(args[0]);
            if (company != null)
            {
                Building building = company.GetBuildingByName(args[1]);
                Broker broker = company.GetBrokerByName(args[2]);
                if(building != null)
                {
                    if (!building.isAvailable)
                    {
                        return $"Building: {building.Name} cannot be rented!";
                    }
                    if(broker != null)
                    {
                        building.isAvailable = false;
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
            Company company = GetCompanyByName(args[0]);
            if(company == null)
            {
                return $"Invalid Company: {args[0]}. Cannot find it in system!";
            }
            return company.ToString();
        }

        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Companies: {this.companies.Count}");
            foreach (Company company in companies.OrderBy(c => c.Name))
            {
                sb.AppendLine(company.ToString());
            }
            return sb.ToString();
        }

    }
}
