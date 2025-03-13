using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuReviewBand : Menu
{
    // Function for the User to Review a Band
    public override void Run(Dictionary<string, Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        DisplayOptionTitle("Review a Band");
        // Receives the Band's Name Typed by the User
        Console.Write("Enter the Name of the Band that you wish to Review: ");
        string bandName = Console.ReadLine()!;

        // If the Band is found in the Band Dictionary, Registers the Review
        if (bandsDictionary.ContainsKey(bandName))
        {
            Band band = bandsDictionary[bandName];
            Console.Write($"\nRate the Band {bandName}: ");
            Review review = Review.Parse(Console.ReadLine()!);
            band.AddReview(review);
            Console.WriteLine($"\nThe review {review.Rate} was Successfully Registered to the Band {bandName}!");
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
