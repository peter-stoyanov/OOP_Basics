using System;
using System.Linq;

public class WaterNation : Nation
{
    public WaterNation() : base(BenderType.Water)
    {

    }

    public override double GetNationPower()
    {
        var nationBenders = base._benders.Where(b => b is WaterBender).Select(b => b.Power).Sum();
        var nationMonuments = nationBenders * (this._monuments.Where(m => m is WaterMonument).Select(m => ((WaterMonument)m).WaterAffinity).Sum()) / 100;

        return nationBenders + nationMonuments;
    }


}
