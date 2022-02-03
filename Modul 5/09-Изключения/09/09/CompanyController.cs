using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public class CompanyController
    {
        private List<Company> companies = new List<Company>();
        public string CreateCompany(List<string> args)
        {
            Company company= new Company(args[0]);
            this.companies.Add(company);
            return company.Name;
        }
        public string RegisterBuildings(List<string> args)
        {
            Building building = null;
            switch (args[0])
            {
                case "Hotel":
                    building = new Hotel(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
                case "Residence":
                    break;
                case "Business":
                    break;
        }
    }
}
