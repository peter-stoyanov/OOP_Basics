public abstract class Monument
{
    private string _name;

    public Monument(string name)
    {
        this.Name = name;
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
}
