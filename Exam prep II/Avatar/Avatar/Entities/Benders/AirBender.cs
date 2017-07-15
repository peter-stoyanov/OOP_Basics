class AirBender : Bender
{
    private double _aerialIntegrity;

    public AirBender(string name, int power, double secondaryParameter)
        : base(name, power)
    {
        this.AerialIntegrity = secondaryParameter;
    }

    public double AerialIntegrity
    {
        get
        {
            return this._aerialIntegrity;
        }
        set
        {
            this._aerialIntegrity = value;
        }
    }

    public override int Power
    {
        get
        {
            return (int)(base._power * this._aerialIntegrity);
        }
    }

    public override string ToString()
    {
        return $"Air Bender: {this.Name}, Power: {this.Power:f2}, Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}
