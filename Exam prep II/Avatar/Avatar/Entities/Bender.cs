public abstract class Bender
{
    private string _name;
    protected int _power;

    protected Bender(string name, int power)
    {
        this.Name = name;
        this._power = power;
    }

    public string Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value; // TODO: validation ?
        }
    }

    public abstract int Power { get; }
}
