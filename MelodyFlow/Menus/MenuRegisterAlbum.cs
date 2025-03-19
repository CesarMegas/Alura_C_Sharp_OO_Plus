using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuViewBandDetails : Menu
{
    //Function that Runs the Menu that Views the Bands Details
    public override void Run(Dictionary<string, Models.Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        DisplayOptionTitle("View the Details of a Band");
        // Receives the Name of the Band typed by the User
        Console.Write("Enter the Name of the Band you want to view the details: ");
        string bandName = Console.ReadLine()!;

        // If the Band is found in the Band Dictionary, Displays their Reviews Average
        if (bandsDictionary.ContainsKey(bandName))
        {
            Band band = bandsDictionary[bandName];
            Console.WriteLine($"\nThe Average of {bandName}'s Reviews is {band.Average}.");
            Console.WriteLine($"\n{bandName}'s Discography: ");
            foreach(Album album in band.Albums)
            {
                Console.WriteLine($"· {album.Name} -> {album.Average}");
            }
            Console.WriteLine("\nType a Key to Return to the Main Menu");
            Console.ReadKey();
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
