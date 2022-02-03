using BrokerCompanySystem.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrokerCompanySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateCompany*Deager
            List<string> input = Console.ReadLine().Split('*').ToList();
            CompanyController controller = new CompanyController();

            while (!input[0].Equals("Shutdown"))
            {
                try
                {
                    switch (input[0])
                    {
                        case "CreateCompany":
                            Console.WriteLine(controller.CreateCompany(input.Skip(1).ToList()));
                            break;
                        case "RegisterBroker":
                            Console.WriteLine(controller.RegisterBroker(input.Skip(1).ToList()));
                            break;
                        case "RegisterBuilding":
                            Console.WriteLine(controller.RegisterBuilding(input.Skip(1).ToList()));
                            break;
                        case "RentBuilding":
                            Console.WriteLine(controller.RentBuilding(input.Skip(1).ToList()));
                            break;
                        case "CompanyInfo":
                            Console.WriteLine(controller.CompanyInfo(input.Skip(1).ToList()));
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                input = Console.ReadLine().Split('*').ToList();
            }
            Console.WriteLine(controller.Shutdown());
        }
    }
}
