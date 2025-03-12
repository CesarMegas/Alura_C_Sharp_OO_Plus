// APP NAME: MELODY FLOW

using MelodyFlow.Models;
using MelodyFlow.Menus;

Band strayKids = new("Stray Kids");
strayKids.AddReview(new Review (10));
strayKids.AddReview(new Review(8));
strayKids.AddReview(new Review (6));
Band blackPink = new("Black Pink");
blackPink.AddReview(new Review(10));
blackPink.AddReview(new Review(9));
Band linkinPark = new("Linkin Park");


// BANDS DICTIONARY - Stores all the bands and their reviews that were added to the app
Dictionary<string, Band> bandsDictionary = new();
// ADDING BANDS
bandsDictionary.Add(strayKids.Name, strayKids);
bandsDictionary.Add(blackPink.Name, blackPink);
bandsDictionary.Add(linkinPark.Name, linkinPark);

// MENUS DICTIONARY - Stores all the menus used in the app
Dictionary<int, Menu> options = new();
// ADDING MENUS
options.Add(1, new MenuRegisterBand());
options.Add(2, new MenuRegisterAlbum());
options.Add(3, new MenuDisplayEveryBand());
options.Add(4, new MenuReviewBand());
options.Add(5, new MenuViewBandDetails());
options.Add(0, new MenuEndProgram());

// Function that displays the App's Logo
void DisplayLogo()
{
    //  Displays the App's Name and a Welcome Message
    Console.WriteLine(@"

███╗░░░███╗███████╗██╗░░░░░░█████╗░██████╗░██╗░░░██╗  ███████╗██╗░░░░░░█████╗░░██╗░░░░░░░██╗
████╗░████║██╔════╝██║░░░░░██╔══██╗██╔══██╗╚██╗░██╔╝  ██╔════╝██║░░░░░██╔══██╗░██║░░██╗░░██║
██╔████╔██║█████╗░░██║░░░░░██║░░██║██║░░██║░╚████╔╝░  █████╗░░██║░░░░░██║░░██║░╚██╗████╗██╔╝
██║╚██╔╝██║██╔══╝░░██║░░░░░██║░░██║██║░░██║░░╚██╔╝░░  ██╔══╝░░██║░░░░░██║░░██║░░████╔═████║░
██║░╚═╝░██║███████╗███████╗╚█████╔╝██████╔╝░░░██║░░░  ██║░░░░░███████╗╚█████╔╝░░╚██╔╝░╚██╔╝░
╚═╝░░░░░╚═╝╚══════╝╚══════╝░╚════╝░╚═════╝░░░░╚═╝░░░  ╚═╝░░░░░╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░░
");
    Console.WriteLine("Welcome to Melody Flow 2.0");
}

// Function that coordinates the Main Menu of the App
void DisplayMenuOptions()
{
    // Calls the function that Displays the App's Logo and Shows the App's Options
    DisplayLogo();
    Console.WriteLine("\n(Enter the number corresponding to the desired option)");
    Console.WriteLine("1. Register a Band");
    Console.WriteLine("2. Register a Band's Album");
    Console.WriteLine("3. Display Every Band");
    Console.WriteLine("4. Review a Band");
    Console.WriteLine("5. View the Details of a Band");
    Console.WriteLine("0. End the Program");

    // Receives and Stores the User's Chosen Option
    Console.Write("\nChoose the Option: ");
    string chosenOption = Console.ReadLine()!;
    int numericChosenOption = int.Parse(chosenOption);

    // Redirects the User to the Chosen Option
    if (options.ContainsKey(numericChosenOption))
    {
        Menu menuToBeDisplayed = options[numericChosenOption];
        menuToBeDisplayed.Run(bandsDictionary);
        if (numericChosenOption > 0) DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine("\nUnvalid Option!");
    }
}

// Starts the App with the Main Menu
DisplayMenuOptions();
