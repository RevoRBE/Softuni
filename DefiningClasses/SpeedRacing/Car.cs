using System;

public class Car
{
    public string model;
    public double fuelAmmount;
    public double fuelCost;
    public double mileage;

    public Car(string model, double fuelAmmount, double fuelCost)
    {
        this.model = model;
        this.fuelAmmount = fuelAmmount;
        this.fuelCost = fuelCost;
        this.mileage = 0;
    }

    public void Drive(double distance)
    {
        if (this.fuelAmmount >= distance * this.fuelCost)
        {
            this.fuelAmmount -= distance * this.fuelCost;
            this.mileage += distance;
        }
        else Console.WriteLine("Insufficient fuel for the drive");
    }

    public override string ToString()
    {
        return String.Format($"{this.model} {this.fuelAmmount:F2} {this.mileage}");
    }
}