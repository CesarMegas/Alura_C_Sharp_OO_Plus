// APP NAME: MELODY FLOW

using MelodyFlow.Models;

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
    switch (numericChosenOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            RegisterAlbum();
            break;
        case 3:
            DisplayEveryBand();
            break;
        case 4:
            ReviewBand();
            break;
        case 5:
            ViewBandDetails();
            break;
        case 0:
            EndProgram();
            break;
        default:
            Console.WriteLine("\nUnvalid Option!");
            break;
    }
}

// Function that Draws the Title of the Chosen Option
void DisplayOptionTitle(string title)
{
    // Transforms the Chosen Option's Number of Characters into two lines of asterisks
    int numberOfCharacters = title.Length;
    string asterisks = string.Empty.PadLeft(numberOfCharacters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine($"{asterisks}\n");
}

// Function that Registers a Band
void RegisterBand()
{
    Console.Clear();
    DisplayOptionTitle("Register a Band");
    // Requests the User for the Name of the Band he wishes to Register, stores the Typed Name, and Adds it to the Band Dictionary
    Console.Write("\nEnter the Name of the Band that you wish to register: ");
    string bandName = Console.ReadLine()!;
    Band band = new(bandName);
    bandsDictionary.Add(bandName, band);
    Console.WriteLine($"The Band {bandName} was successfully added!");
    Thread.Sleep(3000);
    Console.Clear();
    DisplayMenuOptions();
}

// Function that Registers a Band's Album
void RegisterAlbum()
{
    Console.Clear();
    DisplayOptionTitle("Register a Band's Album");
    Console.WriteLine("Enter the Band whose Album you want to Register: ");
    string bandName = Console.ReadLine()!;
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
    else
    {
        Console.WriteLine($"\nThe Band {bandName} was not found...");
        Console.WriteLine("\nType a Key to Return to the Main Menu");
        Console.ReadKey();
        Console.Clear();
    }
    DisplayMenuOptions();
}

// Function that Displays every Band that was Registered
void DisplayEveryBand()

{
    Console.Clear();
    DisplayOptionTitle("Display Every Band");
    Console.WriteLine("\n");

    foreach (string band in bandsDictionary.Keys)
    {
        Console.WriteLine($"Band: {band}");
    }

    Console.WriteLine("\nType a Key to Return to the Main Menu");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

// Function for the User to Review a Band
void ReviewBand()
{
    Console.Clear();
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
        DisplayMenuOptions();
    }
    // Else, displays an Error message and returns to the Main Menu
    else
    {
        Console.WriteLine($"\nThe Band {bandName} was not found...");
        Console.WriteLine("\nType a Key to Return to the Main Menu");
        Console.ReadKey();
        Console.Clear();
        DisplayMenuOptions();
    }
}

// Função que exibe a Média das Notas de uma Banda
void ViewBandDetails()
{
    Console.Clear();
    DisplayOptionTitle("View the Details of a Band");
    // Recebe o Nome da Banda Digitada pelo Usuário
    Console.Write("Enter the Name of the Band you want to view the details: ");
    string bandName = Console.ReadLine()!;

    // If the Band is found in the Band Dictionary, Displays their Reviews Average
    if (bandsDictionary.ContainsKey(bandName))
    {
        Band band = bandsDictionary[bandName];
        Console.WriteLine($"\nThe Average of {bandName}'s Reviews is {band.Average}.");
        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("\nType a Key to Return to the Main Menu");
        Console.ReadKey();
        Console.Clear();
        DisplayMenuOptions();
    }
    // Else, displays an Error message and returns to the Main Menu
    else
    {
        Console.WriteLine($"\nThe Band {bandName} was not found...");
        Console.WriteLine("\nType a Key to Return to the Main Menu");
        Console.ReadKey();
        Console.Clear();
        DisplayMenuOptions();
    }

}

// Function that Ends the App
void EndProgram()
{
    Console.Clear();
    Console.WriteLine("End of Program!");
}

// Starts the App with the Main Menu
DisplayMenuOptions();
