using System;
using System.Linq;

public class AirNation : Nation
{
    public AirNation() : base(BenderType.Air)
    {

    }

    public override double GetNationPower()
    {
        var nationBenders = base._benders.Where(b => b is AirBender).Select(b => b.Power).Sum();
        var nationMonuments = nationBenders * (this._monuments.Where(m => m is AirMonument).Select(m => ((AirMonument)m).AirAffinity).Sum()) / 100;

        return nationBenders + nationMonuments;
    }


}
