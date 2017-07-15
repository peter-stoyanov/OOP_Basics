public class FireMonument : Monument
{
    private double _fireAffinity;

    public FireMonument(string name, double affinity)
        : base(name)
    {
        this.FireAffinity = affinity;
    }

    public double FireAffinity
    {
        get
        {
            return this._fireAffinity;
        }
        set
        {
            this._fireAffinity = value;
        }
    }

    public override string ToString()
    {
        return $"Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity:f2}";
    }
}

