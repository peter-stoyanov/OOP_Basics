using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester GetHarvester(string type, string id, double oreOutput, double energyRequirement, int sonicFactor = 0)
    {
        if (type == "Sonic")
        {
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
        else if (type == "Hammer")
        {
            return new HammerHarvester(id, oreOutput, energyRequirement);
        }

        return null;
    }
}
