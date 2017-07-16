using System;
using System.Collections.Generic;

public class SonicHarvester : Harvester
{
    private int sonicFactor;
    private double intialEnerryReq;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement / sonicFactor)
    {
        this.InitialEnergyReq = energyRequirement;
        this.SonicFactor = sonicFactor;
    }

    public double InitialEnergyReq
    {
        get { return this.intialEnerryReq; }
        private set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Energy requirement must be not negative.");
            }
            else
            {
                this.intialEnerryReq = value;
            }
        }
    }

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        private set
        {
            if (value >= 1 && value <= 10)
            {
                this.sonicFactor = value;
            }
            else
            {
                throw new ArgumentException("Sonic factor must be not negative.");
            }
            //if (base.EnergyRequirement < 0 || base.EnergyRequirement > 20000)
            //{
            //    throw new ArgumentException("Energy requirement must be not negative.");
            //}
        }
    }
}
