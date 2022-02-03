using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public class Engine
    {
        public void Run()
        {
            string[] commandLine = Console.ReadLine().Split();
            StorageMaster storageMaster = new StorageMaster();

            while (!commandLine[0].Equals("END"))
            {
                try
                {
                    switch (commandLine[0])
                    {
                        //AddProduct Gpu 1200
                        case "AddProduct":
                            Console.WriteLine(storageMaster.AddProduct(commandLine[1], double.Parse(commandLine[2])));
                            break;
                        //RegisterStorage DistributionCenter SofiaDistribution
                        case "RegisterStorage":
                            Console.WriteLine(storageMaster.RegisterStorage(commandLine[1], commandLine[2]));
                            break;
                        //SelectVehicle SofiaDistribution 0
                        case "SelectVehicle":
                            Console.WriteLine(storageMaster.SelectVehicle(commandLine[1], int.Parse(commandLine[2])));
                            break;
                        //LoadVehicle HardDrive Gpu
                        case "LoadVehicle":
                            Console.WriteLine(storageMaster.LoadVehicle(commandLine.Skip(1)));
                            break;
                        //SendVehicleTo SofiaDistribution 0 AmazonWarehouse
                        case "SendVehicleTo":
                            Console.WriteLine(storageMaster.SendVehicleTo(commandLine[1], int.Parse(commandLine[2]), commandLine[3]));
                            break;
                        case "UnloadVehicle":
                            Console.WriteLine(storageMaster.UnloadVehicle(commandLine[1], int.Parse(commandLine[2])));
                            break;
                        case "GetStorageStatus":
                            Console.WriteLine(storageMaster.GetStorageStatus(commandLine[1]));
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                commandLine = Console.ReadLine().Split();
            }

            Console.WriteLine(storageMaster.GetSummary());
        }
    }
}
