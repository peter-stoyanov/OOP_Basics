public class WaterMonument : Monument
{
    private double _waterAffinity;

    public WaterMonument(string name, double affinity)
        : base(name)
    {
        this.WaterAffinity = affinity;
    }

    public double WaterAffinity
    {
        get
        {
            return this._waterAffinity;
        }
        set
        {
            this._waterAffinity = value;
        }
    }

    public override string ToString()
    {
        return $"Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity:f2}";
    }   
}

