using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Nation
{
    protected List<Bender> _benders;
    protected List<Monument> _monuments;
    protected string _type;

    public Nation(string type)
    {
        this._benders = new List<Bender>();
        this._monuments = new List<Monument>();
        this._type = type;
    }

    public abstract double GetNationPower();

    public void AddBender(Bender bender)
    {
        this._benders.Add(bender);
    }

    public int Count => this._benders.Count;

    public void AddMonument(Monument monument)
    {
        this._monuments.Add(monument);
    }

    public void RemoveAll()
    {
        this._benders = new List<Bender>();
        this._monuments = new List<Monument>();
    }

    public string PrintNation()
    {
        if (this._benders.Count > 0)
        {
            var benderType = this._benders.FirstOrDefault().GetType();
            var monumentType = this._monuments.Count > 0 ? this._monuments.FirstOrDefault().GetType() : null;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{this._type} Nation{Environment.NewLine}");

            sb.Append("Benders:");

            var benders = this._benders.Where(b => b.GetType() == benderType).ToList();
            var monuments = monumentType != null ? this._monuments.Where(m => m.GetType() == monumentType).ToList() : null;
            if (benders.Count == 0)
            {
                sb.Append($" None{Environment.NewLine}");
            }
            else
            {
                sb.Append($"{Environment.NewLine}");
                foreach (var bender in benders)
                {
                    sb.Append($"###{bender.ToString()}{Environment.NewLine}");
                }
            }
            sb.Append("Monuments:");
            if (monuments == null || monuments.Count == 0)
            {
                sb.Append($" None{Environment.NewLine}");
            }
            else
            {
                sb.Append($"{Environment.NewLine}");
                foreach (var monument in monuments)
                {
                    sb.Append($"###{monument.ToString()}{Environment.NewLine}");
                }
            }
            return sb.ToString();
        }

        return "";
    }

}
