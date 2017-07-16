using System;
using System.Text;

public abstract class Harvester : Worker
{
    //private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        //this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    //public string Id
    //{
    //    get { return this.id; }
    //    private set { this.id = value; }
    //}

    public double OreOutput
    {
        get { return this.oreOutput; }
        private set
        {
            if (value >= 0)
            {
                this.oreOutput = value;
            }
            else
            {
                throw new ArgumentException("Ore output must be not negative.");
            }
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        private set
        {
            if (value >= 0 && value <= 20000)
            {
                this.energyRequirement = value;
            }
            else
            {
                throw new ArgumentException("Energy requirement must be not negative.");
            }
        }
    }

    public double GetEnergyRequirementByMode(string mode)
    {
        switch (mode)
        {
            case "Full":
                return this.EnergyRequirement;
            case "Half":
                return this.EnergyRequirement * 0.6;
            case "Energy":
                return 0;
        }

        return this.EnergyRequirement;
    }

    public double GetOreOutputByMode(string mode)
    {
        switch (mode)
        {
            case "Full":
                return this.OreOutput;
            case "Half":
                return this.OreOutput * 0.5;
            case "Energy":
                return 0;
        }

        return this.OreOutput;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"{this.GetType().Name.Substring(0, this.GetType().Name.IndexOf("Harvester"))} Harvester - {base.Id}{Environment.NewLine}");
        
        sb.Append($"Ore Output: {this.OreOutput}{Environment.NewLine}");

        sb.Append($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString();
    }
}
