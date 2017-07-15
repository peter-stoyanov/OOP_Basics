using System;
using System.Linq;

public class FireNation : Nation
{
    public FireNation() : base(BenderType.Fire)
    {

    }

    public override double GetNationPower()
    {
        var nationBenders = base._benders.Where(b => b is FireBender).Select(b => b.Power).Sum();
        var nationMonuments = nationBenders * (this._monuments.Where(m => m is FireMonument).Select(m => ((FireMonument)m).FireAffinity).Sum()) / 100;

        return nationBenders + nationMonuments;
    }


}
