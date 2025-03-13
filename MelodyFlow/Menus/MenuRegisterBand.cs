using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuRegisterBand : Menu
{
    // Function that Registers a Band
    public override void Run(Dictionary<string, Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        DisplayOptionTitle("Register a Band");
        // Requests the User for the Name of the Band he wishes to Register, stores the Typed Name, and Adds it to the Band Dictionary
        Console.Write("\nEnter the Name of the Band that you wish to register: ");
        string bandName = Console.ReadLine()!;
        Band band = new(bandName);
        bandsDictionary.Add(bandName, band);
        Console.WriteLine($"The Band {bandName} was successfully added!");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
