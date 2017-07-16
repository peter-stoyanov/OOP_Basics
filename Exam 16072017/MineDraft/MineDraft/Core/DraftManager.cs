using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private string mode;
    private ProviderFactory providerFactory;
    private HarvesterFactory harvesterFactory;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.mode = "Full";
        this.providerFactory = new ProviderFactory();
        this.harvesterFactory = new HarvesterFactory();
    }

    private string AddHarvester(Harvester harvester)
    {
        if (this.harvesters.ContainsKey(harvester.Id))
        {
            return "id";
        }
        else
        {
            this.harvesters.Add(harvester.Id, harvester);
            return "";
        }
    }

    private string AddProvider(Provider provider)
    {
        if (this.providers.ContainsKey(provider.Id))
        {
            return "id";
        }
        else
        {
            this.providers.Add(provider.Id, provider);
            return "";
        }
    }

    public string RegisterHarvester(List<string> arguments)
    {
        //RegisterHarvester Sonic AS-51 100 100 10
        string id = arguments[1];
        double oreOutput;
        double energyRequirement;

        try
        {
            oreOutput = double.Parse(arguments[2]);
        }
        catch (Exception)
        {
            return "Harvester is not registered, because of it's Oreoutput";
        }

        try
        {
            energyRequirement = double.Parse(arguments[3]);
        }
        catch (Exception)
        {
            return "Harvester is not registered, because of it's EnergyRequirement";
        }


        if (arguments[0] == "Sonic")
        {
            int sonicFactor;
            try
            {
                sonicFactor = int.Parse(arguments[4]);
            }
            catch (Exception)
            {
                return "Harvester is not registered, because of it's SonicFactor";
            }

            try
            {
                //var newSonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                var newSonicHarvester = this.harvesterFactory.GetHarvester("Sonic", id, oreOutput, energyRequirement, sonicFactor);

                string success = this.AddHarvester(newSonicHarvester);
                if (success == "id")
                {
                    return "Harvester is not registered, because of it's Id";
                }
                else
                {
                    return $"Successfully registered Sonic Harvester - {newSonicHarvester.Id}";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Ore output"))
                {
                    return "Harvester is not registered, because of it's OreOutput";
                }
                else if (ex.Message.Contains("Energy requirement"))
                {
                    return "Harvester is not registered, because of it's EnergyRequirement";
                }
                else if (ex.Message.Contains("Solar"))
                {
                    return "Harvester is not registered, because of it's SolarFactor";
                }
                return "general error";
            }

        }
        else
        {
            try
            {
                //var newHammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                var newHammerHarvester = this.harvesterFactory.GetHarvester("Hammer", id, oreOutput, energyRequirement);

                string success = this.AddHarvester(newHammerHarvester);
                if (success == "id")
                {
                    return "Harvester is not registered, because of it's Id";
                }
                else
                {
                    return $"Successfully registered Hammer Harvester - {newHammerHarvester.Id}";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Ore output"))
                {
                    return "Harvester is not registered, because of it's OreOutput";
                }
                else if (ex.Message.Contains("Energy requirement"))
                {
                    return "Harvester is not registered, because of it's EnergyRequirement";
                }
                return "general error";
            }
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        //RegisterProvider Solar Falcon 100
        string id = arguments[1];
        double energyOutput;

        try
        {
            energyOutput = double.Parse(arguments[2]);
        }
        catch (Exception)
        {
            return "Provider is not registered, because of it's EnergyOutput";
        }


        if (arguments[0] == "Solar")
        {
            try
            {
                //var newSolarProvider = new SolarProvider(id, energyOutput);
                var newSolarProvider = this.providerFactory.GetProvider("Solar", id, energyOutput);

                string success = this.AddProvider(newSolarProvider);
                if (success == "id")
                {
                    return "Provider is not registered, because of it's Id";
                }
                else
                {
                    return $"Successfully registered Solar Provider - {newSolarProvider.Id}";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Energy output"))
                {
                    return "Provider is not registered, because of it's EnergyOutput";
                }
                return "general error";
            }

        }
        else
        {
            try
            {
                //var newPressureProvider = new PressureProvider(id, energyOutput);
                var newPressureProvider = this.providerFactory.GetProvider("Pressure", id, energyOutput);

                string success = this.AddProvider(newPressureProvider);
                if (success == "id")
                {
                    return "Provider is not registered, because of it's Id";
                }
                else
                {
                    return $"Successfully registered Pressure Provider - {newPressureProvider.Id}";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Energy output"))
                {
                    return "Provider is not registered, because of it's EnergyOutput";
                }
                return "general error";
            }
        }
    }

    public string Day()
    {
        //calc all provided energy and store it
        double dailyEnergyOutput = this.providers.Select(p => p.Value.EnergyOutput).Sum();
        this.totalStoredEnergy += dailyEnergyOutput;


        //summ all ener req - harvesters depend on mode
        double dailyEnergyReq = this.harvesters.Select(h => h.Value.GetEnergyRequirementByMode(this.mode)).Sum();

        //- if smaller than take it and produce otherwise rest
        double dailyOreOutput = 0;
        if (dailyEnergyReq <= this.totalStoredEnergy)
        {
            this.totalStoredEnergy -= dailyEnergyReq;
            dailyOreOutput = this.harvesters.Select(h => h.Value.GetOreOutputByMode(this.mode)).Sum();
            this.totalMinedOre += dailyOreOutput;
        }
        
        //print daily result
        StringBuilder sb = new StringBuilder();

        sb.Append($"A day has passed.{Environment.NewLine}");

        sb.Append($"Energy Provided: {dailyEnergyOutput}{Environment.NewLine}");

        sb.Append($"Plumbus Ore Mined: {dailyOreOutput}");

        return sb.ToString();
    }

    public string Mode(List<string> arguments)
    {
        string mode = arguments[0];

        if (mode == "Full") { this.mode = "Full"; }
        if (mode == "Half") { this.mode = "Half"; }
        if (mode == "Energy") { this.mode = "Energy"; }

        return $"Successfully changed working mode to {this.mode} Mode"; //if incorrect input ?
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];

        if (this.harvesters.ContainsKey(id))
        {
            return this.harvesters[id].ToString();
        }
        else if (this.providers.ContainsKey(id))
        {
            return this.providers[id].ToString();
        }

        return $"No element found with id - {arguments[0]}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"System Shutdown{Environment.NewLine}");

        sb.Append($"Total Energy Stored: {this.totalStoredEnergy}{Environment.NewLine}");

        sb.Append($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString();
    }

}
