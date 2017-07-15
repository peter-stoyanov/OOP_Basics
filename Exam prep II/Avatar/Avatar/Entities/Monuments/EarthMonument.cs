public class EarthMonument : Monument
{
    private double _earthAffinity;

    public EarthMonument(string name, double affinity)
        : base(name)
    {
        this.EarthAffinity = affinity;
    }

    public double EarthAffinity
    {
        get
        {
            return this._earthAffinity;
        }
        set
        {
            this._earthAffinity = value;
        }
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity:f2}";
    }
}

