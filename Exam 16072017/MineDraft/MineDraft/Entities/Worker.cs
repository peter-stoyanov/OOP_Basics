using System;
using System.Text;

public abstract class Worker
{
    private string id;

    public Worker(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }
}
