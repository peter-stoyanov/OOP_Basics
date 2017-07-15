public class AirMonument : Monument
{
    private double _airAffinity;

    public AirMonument(string name, double affinity)
        : base(name)
    {
        this.AirAffinity = affinity;
    }

    public double AirAffinity
    {
        get
        {
            return this._airAffinity;
        }
        set
        {
            this._airAffinity = value;
        }
    }

    public override string ToString()
    {
        return $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity:f2}";
    }
}

