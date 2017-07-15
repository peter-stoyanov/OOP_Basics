using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private AirNation _airNation;
    private EarthNation _earthNation;
    private FireNation _fireNation;
    private WaterNation _waterNation;

    private List<string> _wars;

    public NationsBuilder()
    {
        this._wars = new List<string>();

        this._airNation = new AirNation();
        this._earthNation = new EarthNation();
        this._fireNation = new FireNation();
        this._waterNation = new WaterNation();
    }

    private void ClearNation(string benderType)
    {
        switch (benderType)
        {
            case BenderType.Air:
                this._airNation.RemoveAll();
                break;
            case BenderType.Earth:
                this._earthNation.RemoveAll();
                break;
            case BenderType.Fire:
                this._fireNation.RemoveAll();
                break;
            case BenderType.Water:
                this._waterNation.RemoveAll();
                break;
        }
    }

    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double secondaryParameter = double.Parse(benderArgs[3]);

        switch (type)
        {
            case BenderType.Air:
                this._airNation.AddBender(new AirBender(name, power, secondaryParameter));
                break;
            case BenderType.Earth:
                this._earthNation.AddBender(new EarthBender(name, power, secondaryParameter));
                break;
            case BenderType.Fire:
                this._fireNation.AddBender(new FireBender(name, power, secondaryParameter));
                break;
            case BenderType.Water:
                this._waterNation.AddBender(new WaterBender(name, power, secondaryParameter));
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[0];
        string name = monumentArgs[1];
        double affinity = double.Parse(monumentArgs[2]);

        switch (type)
        {
            case MonumentType.Air:
                this._airNation.AddMonument(new AirMonument(name, affinity));
                break;
            case MonumentType.Earth:
                this._earthNation.AddMonument(new EarthMonument(name, affinity));
                break;
            case MonumentType.Fire:
                this._fireNation.AddMonument(new FireMonument(name, affinity));
                break;
            case MonumentType.Water:
                this._waterNation.AddMonument(new WaterMonument(name, affinity));
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        switch (nationsType)
        {
            case NationType.Air:
                return this._airNation.PrintNation();
            case NationType.Earth:
                return this._earthNation.PrintNation();
            case NationType.Fire:
                return this._fireNation.PrintNation();
            case NationType.Water:
                return this._waterNation.PrintNation();
            default:
                return "";
        }
    }

    public void IssueWar(string nationsType)
    {
        this._wars.Add($"War {this._wars.Count + 1} issued by {nationsType}");

        var nations = new Dictionary<double, Nation>();

        if (this._airNation.Count > 0) { nations.Add(this._airNation.GetNationPower(), this._airNation); }
        if (this._earthNation.Count > 0) { nations.Add(this._earthNation.GetNationPower(), this._earthNation); }
        if (this._fireNation.Count > 0) { nations.Add(this._fireNation.GetNationPower(), this._fireNation); }
        if (this._waterNation.Count > 0) { nations.Add(this._waterNation.GetNationPower(), this._waterNation); }

        foreach (var nation in nations.OrderBy(n => n.Key).Skip(1))
        {
            nation.Value.RemoveAll();
        }
    }

    public string GetWarsRecord()
    {
        return string.Join("\n", this._wars);
    }
}
