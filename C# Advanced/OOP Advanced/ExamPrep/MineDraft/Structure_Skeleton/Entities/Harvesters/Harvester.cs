using System;
public abstract class Harvester : IHarvester
{
    private const int InitialDurability = 1000;
    private double durability;

    public virtual double Durability
    {
        get { return this.durability; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(Constants.BrokenEntity, this.GetType().Name, this.ID));
            }
            this.durability = value;
        }
    }

    private double oreOutput;
    private double energyRequirement;

    protected Harvester(int id, double oreOutput, double energyRequirement)
    {
        this.ID = id;
        this.oreOutput = oreOutput;
        this.energyRequirement = energyRequirement;
        this.Durability = InitialDurability;
    }

    public int ID { get; }

    public double OreOutput { get; protected set; }

    public double EnergyRequirement { get; protected set; }


    public void Broke()
    {
        this.Durability -= 100;
    }

    public double Produce()
    {
        return this.OreOutput;
    }
}