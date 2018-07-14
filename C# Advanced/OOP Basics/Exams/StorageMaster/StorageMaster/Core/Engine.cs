using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class Engine
    {
        private readonly StorageMaster master;
        public Engine()
        {
            this.master = new StorageMaster();
        }
        internal void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = args[0];
                
                switch (command)
                {
                    case "RegisterStorage":
                        Console.WriteLine(this.master.RegisterStorage(args[1], args[2]));
                        break;
                    case "AddProduct":
                        Console.WriteLine(this.master.AddProduct(args[1], double.Parse(args[2])));
                        break;
                    case "SelectVehicle":
                        Console.WriteLine(this.master.SelectVehicle(args[1], int.Parse(args[2])));
                        break;
                    case "LoadVehicle":
                        Console.WriteLine(this.master.LoadVehicle(args.Skip(1)));
                        break;
                    case "SendVehicleTo":
                        Console.WriteLine(this.master.SendVehicleTo(args[1], int.Parse(args[2]), args[3]));
                        break;
                    case "UnloadVehicle":
                        Console.WriteLine(this.master.UnloadVehicle(args[1], int.Parse(args[2])));
                        break;
                    case "GetStorageStatus":
                        Console.WriteLine(this.master.GetStorageStatus(args[1]));
                        break;
                    default: throw new InvalidOperationException("Invalid command!");
                }
            }
        }
    }
}
