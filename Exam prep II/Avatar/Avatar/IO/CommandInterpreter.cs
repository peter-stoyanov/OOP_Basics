using System;
using System.Linq;

public class CommandInterpreter
{
    private const string END_COMMAND = "Quit";

    private bool isRunning;
    private NationsBuilder _nationsBuilder;

    public CommandInterpreter()
    {
        this._nationsBuilder = new NationsBuilder();
    }

    public void Start()
    {
        this.isRunning = true;

        while (this.isRunning)
        {
            string input = Console.ReadLine().Trim();
            this.ExecuteCommand(input);
        }
    }

    public void ExecuteCommand(string input)
    {
        var data = input.Split(' ').ToList();
        string command = data[0];
        switch (command)
        {
            case "Bender":
                var args = data.Skip(1).ToList();
                this._nationsBuilder.AssignBender(args);
                break;
            case "Monument":
                args = data.Skip(1).ToList();
                this._nationsBuilder.AssignMonument(args);
                break;
            case "Status":
                string status = this._nationsBuilder.GetStatus(data[1]);
                Console.WriteLine(status);
                break;
            case "War":
                this._nationsBuilder.IssueWar(data[1]);
                break;
            case "Quit":
                string records = this._nationsBuilder.GetWarsRecord();
                Console.WriteLine(records);
                this.isRunning = false;
                break;
        }
    }

}