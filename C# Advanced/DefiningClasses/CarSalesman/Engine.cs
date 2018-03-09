using System;
using System.Text;

public class Engine
{
    private string model;
    private int power;
    private int? displacement;
    private string efficiency;

    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
    }

    public string Model => this.model;
    

    public int Displaacement
    {
        set { this.displacement = value; }
    }

    public string Efficiency
    {
        set { this.efficiency = value; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"  {this.model}:");
        result.AppendLine($"    Power: {this.power}");
        result.AppendLine(this.displacement == null ? "    Displacement: n/a" : $"    Displacement: {this.displacement}");
        result.Append(this.efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {this.efficiency}");
       
        //var result = $"  {this.model}:";
        //result = string.Concat(result, Environment.NewLine);
        //result = string.Concat(result, $"    Power: {this.power}");
        //result = string.Concat(result, Environment.NewLine);
        //result = string.Concat(result, this.displacement == null ? "    Displacement: n/a" : $"    Displacement: {this.displacement}");
        //result = string.Concat(result, Environment.NewLine);
        //result = string.Concat(result, this.efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {this.efficiency}");

        return result.ToString();
    }
}