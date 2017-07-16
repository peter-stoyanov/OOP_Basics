using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public Provider GetProvider(string type, string id, double energyOutput)
    {
        if (type == "Solar")
        {
            return new SolarProvider(id, energyOutput);
        }
        else if (type == "Pressure")
        {
            return new PressureProvider(id, energyOutput);
        }

        return null;
    }
}
