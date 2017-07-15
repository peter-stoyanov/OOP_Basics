class WaterBender : Bender
{
    private double _waterClarity;

    public WaterBender(string name, int power, double secondaryParameter)
        : base(name, power)
    {
        this.WaterClarity = secondaryParameter;
    }

    public double WaterClarity
    {
        get
        {
            return this._waterClarity;
        }
        set
        {
            this._waterClarity = value;
        }
    }

    public override int Power
    {
        get
        {
            return (int)(base._power * this._waterClarity);
        }
    }

    public override string ToString()
    {
        return $"Water Bender: {this.Name}, Power: {this.Power:f2}, Water Clarity: {this.WaterClarity:f2}";
    }
}
