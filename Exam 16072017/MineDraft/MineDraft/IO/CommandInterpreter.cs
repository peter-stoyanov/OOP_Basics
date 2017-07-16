using System;
using System.Linq;

public class CommandInterpreter
{
    //private const string END_COMMAND = "Shutdown";

    private bool isRunning;
    private DraftManager draftManager;

    public CommandInterpreter()
    {
        this.draftManager = new DraftManager();
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
        data.Remove(command);
        switch (command)
        {
            case "RegisterHarvester":
                string result = this.draftManager.RegisterHarvester(data);
                Console.WriteLine(result);
                break;
            case "RegisterProvider":
                result = this.draftManager.RegisterProvider(data);
                Console.WriteLine(result);
                break;
            case "Check":
                result = this.draftManager.Check(data);
                Console.WriteLine(result);
                break;
            case "Day":
                result = this.draftManager.Day();
                Console.WriteLine(result);
                break;
            case "Mode":
                result = this.draftManager.Mode(data);
                Console.WriteLine(result);
                break;
            case "Shutdown":
                result = this.draftManager.ShutDown();
                Console.WriteLine(result);
                this.isRunning = false;
                break;
        }
    }

}