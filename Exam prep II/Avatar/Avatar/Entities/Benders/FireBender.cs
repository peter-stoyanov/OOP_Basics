class FireBender : Bender
{
    private double _heatAggression;

    public FireBender(string name, int power, double secondaryParameter)
        : base(name, power)
    {
        this.HeatAggression = secondaryParameter;
    }

    public double HeatAggression
    {
        get
        {
            return this._heatAggression;
        }
        set
        {
            this._heatAggression = value;
        }
    }

    public override int Power
    {
        get
        {
            return (int)(base._power * this._heatAggression);
        }
    }

    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power:f2}, Heat Aggression: {this.HeatAggression:f2}";
    }
}
