using StorageMaster.Entities.Vehicles;
using System;

namespace Logger.Models.Factories
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string vehicleType)
        {
            Vehicle vehicle = null; 
            switch (vehicleType)
            {
                case "Semi":
                    vehicle = new Semi();
                    break;
                case "Truck":
                    vehicle = new Truck();
                    break;
                case "Van":
                    vehicle = new Van();
                    break;
                default:
                    throw new InvalidOperationException("Ivalid vehicle type");
            }
            return vehicle;
        }
    }
}
