using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        Car[] cars = new Car[count];

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();
            string model = tokens[0];
            double fuelAmmount = double.Parse(tokens[1]);
            double fuelCost = double.Parse(tokens[2]);
            cars[i] = new Car(model, fuelAmmount, fuelCost);
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command.Split();
            string model = tokens[1];
            double distance = double.Parse(tokens[2]);

            cars.Where(c => c.model == model).ToList().ForEach(c => c.Drive(distance));
        }

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
