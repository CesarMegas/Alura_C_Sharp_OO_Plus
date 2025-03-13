using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuDisplayEveryBand : Menu
{
    // Function that Displays every Band that was Registered
    public override void Run(Dictionary<string, Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        DisplayOptionTitle("Display Every Band");
        Console.WriteLine("\n");

        //Runs a loop that goes through every element of the Bands Dictionaty and Displays the Name of the Band
        foreach (string band in bandsDictionary.Keys)
        {
            Console.WriteLine($"Band: {band}");
        }

        Console.WriteLine("\nType a Key to Return to the Main Menu");
        Console.ReadKey();
        Console.Clear();
    }
}
