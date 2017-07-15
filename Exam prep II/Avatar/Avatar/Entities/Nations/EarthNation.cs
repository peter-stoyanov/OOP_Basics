using System;
using System.Linq;

public class EarthNation : Nation
{
    public EarthNation() : base(BenderType.Earth)
    {

    }

    public override double GetNationPower()
    {
        var nationBenders = base._benders.Where(b => b is EarthBender).Select(b => b.Power).Sum();
        var nationMonuments = nationBenders * (this._monuments.Where(m => m is EarthMonument).Select(m => ((EarthMonument)m).EarthAffinity).Sum()) / 100;

        return nationBenders + nationMonuments;
    }


}
