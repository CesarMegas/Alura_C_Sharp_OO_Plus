using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuRegisterAlbum : Menu
{
    // Function that Registers a Band's Album
    public override void Run(Dictionary<string, Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        DisplayOptionTitle("Register a Band's Album");
        // Requests the Name of the Band the User wants to register an album to
        Console.WriteLine("Enter the Band whose Album you want to Register: ");
        string bandName = Console.ReadLine()!;

        // If the Band is found in the Band Dictionary, Registers the Album
        if (bandsDictionary.ContainsKey(bandName))
        {
            Console.WriteLine("\nNow Enter the Album's Title: ");
            string albumTitle = Console.ReadLine()!;
            Band band = bandsDictionary[bandName];
            band.AddAlbum(new Album(albumTitle));
            Console.WriteLine($"The Album {albumTitle} from {bandName} was successfully registered!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        // Else, displays an Error message and returns to the Main Menu
        else
        {
            Console.WriteLine($"\nThe Band {bandName} was not found...");
            Console.WriteLine("\nType a Key to Return to the Main Menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
