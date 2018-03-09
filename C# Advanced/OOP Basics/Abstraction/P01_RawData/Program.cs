using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = CarParser();
           
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.cargo.type == "fragile" && x.tires.Any(y => y.pressure < 1))
                    .Select(x => x.model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.cargo.type == "flamable" && x.engine.Power > 250)
                    .Select(x => x.model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        private static List<Car> CarParser()
        {
            var cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                double tyre1Pressure = double.Parse(parameters[5]);
                int tyre1age = int.Parse(parameters[6]);
                double tyre2Pressure = double.Parse(parameters[7]);
                int tyre2age = int.Parse(parameters[8]);
                double tyre3Pressure = double.Parse(parameters[9]);
                int tyre3age = int.Parse(parameters[10]);
                double tyre4Pressure = double.Parse(parameters[11]);
                int tyre4age = int.Parse(parameters[12]);
                var tires = new Tyre[4]{new Tyre(tyre1Pressure, tyre1age), new Tyre(tyre2Pressure, tyre2age), new Tyre(tyre3Pressure, tyre3age), new Tyre(tyre4Pressure, tyre4age)};
                cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoType, cargoWeight), tires));
            }
            return cars;
        }
    }
}
