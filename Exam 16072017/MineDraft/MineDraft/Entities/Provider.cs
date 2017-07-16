using System;
using System.Text;

public abstract class Provider : Worker
{
    //private string id;
    private double energyOutput;

    public Provider(string id, double energyOutput)
        : base(id)
    {
        //this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    //public string Id
    //{
    //    get { return this.id; }
    //    private set { this.id = value; }
    //}

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        private set
        {
            if (value >= 0 && value <= 10000)
            {
                this.energyOutput = value;
            }
            else
            {
                throw new ArgumentException("Energy output must be between 0 and 10000.");
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"{this.GetType().Name.Substring(0, this.GetType().Name.IndexOf("Provider"))} Provider - {base.Id}{Environment.NewLine}");

        sb.Append($"Energy Output: {this.EnergyOutput}");

        return sb.ToString();
    }
}
