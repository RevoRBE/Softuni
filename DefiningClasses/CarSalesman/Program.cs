using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        Stack<Engine> engines = GetEngines();
        var cars = GetCars(engines);
        PrintCars(cars);
    }

    private static void PrintCars(Queue<Car> cars)
    {
        foreach (var car in cars)
            Console.Write(car.ToString());
    }

    private static Queue<Car> GetCars(Stack<Engine> engines)
    {
        var numberOfCars = int.Parse(Console.ReadLine());
        var cars = new Queue<Car>(numberOfCars);

        while (cars.Count < numberOfCars)
        {
            var input = Console.ReadLine().Trim().Split();
            var currentCar = new Car(input[0], engines.FirstOrDefault(e => e.Model == input[1]));

            if (input.Length > 2)
            {
                int weight;
                var isDigit = int.TryParse(input[2], out weight);

                if (isDigit) currentCar.Weight = weight;
                else currentCar.Color = input[2];

                if (input.Length > 3)
                {
                    if (isDigit) currentCar.Color = input[3];
                    else currentCar.Weight = int.Parse(input[3]);
                }
            }

            cars.Enqueue(currentCar);
        }

        return cars;
    }

    private static Stack<Engine> GetEngines()
    {
        var numberOfEngines = int.Parse(Console.ReadLine());
        var engines = new Stack<Engine>(numberOfEngines);

        while (engines.Count < numberOfEngines)
        {
            var input = Console.ReadLine().TrimEnd().Split();
            engines.Push(new Engine(input[0], int.Parse(input[1])));

            if (input.Length > 2)
            {
                int displacement;
                var isdigit = int.TryParse(input[2], out displacement);

                if (isdigit) engines.Peek().Displaacement = displacement;
                else engines.Peek().Efficiency = input[2];
                
                if (input.Length > 3)
                {
                    if (isdigit) engines.Peek().Efficiency = input[3];
                    else engines.Peek().Displaacement = int.Parse(input[3]);
                }
            }
        }
        return engines;
    }
}