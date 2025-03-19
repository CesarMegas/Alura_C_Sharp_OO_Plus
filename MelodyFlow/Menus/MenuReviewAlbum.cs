using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuReviewAlbum : Menu
{
    // Function for the User to Review an Album
    public override void Run(Dictionary<string, Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        DisplayOptionTitle("Review an Album");
        // Receives the Band's Name Typed by the User
        Console.Write("Enter the Name of the Band that you wish to Review: ");
        string bandName = Console.ReadLine()!;

        // If the Band is found in the Band Dictionary, Asks the Name of the Album
        if (bandsDictionary.ContainsKey(bandName))
        {
            Band band = bandsDictionary[bandName];
            //Receives the Album's Name Typed by the User
            Console.WriteLine("\nNow Enter the Album's Title: ");
            string albumTitle = Console.ReadLine()!;
            // If the Album is found in the Band Dictionary, Registers the Review
            if (band.Albums.Any(a => a.Name.Equals(albumTitle)))
            {
                Album album = band.Albums.First(a => a.Name.Equals(albumTitle));
                Console.Write($"\nRate the Album {albumTitle}: ");
                Review review = Review.Parse(Console.ReadLine()!);
                album.AddReview(review);
                Console.WriteLine($"\nThe review {review.Rate} was Successfully Registered to the Album {albumTitle}!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            // Else, displays an Error message and returns to the Main Menu
            else
            {
                Console.WriteLine($"\nThe Album {albumTitle} was not found...");
                Console.WriteLine("\nType a Key to Return to the Main Menu");
                Console.ReadKey();
                Console.Clear();
            }

            
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
