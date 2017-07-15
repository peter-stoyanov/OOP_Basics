class EarthBender : Bender
{
    private double _groundSaturation;

    public EarthBender(string name, int power, double secondaryParameter)
        : base(name, power)
    {
        this.GroundSaturation = secondaryParameter;
    }

    public double GroundSaturation
    {
        get
        {
            return this._groundSaturation;
        }
        set
        {
            this._groundSaturation = value;
        }
    }

    public override int Power
    {
        get
        {
            return (int)(base._power * this._groundSaturation);
        }
    }

    public override string ToString()
    {
        return $"Earth Bender: {this.Name}, Power: {this.Power:f2}, Ground Saturation: {this.GroundSaturation:f2}";
    }
}
