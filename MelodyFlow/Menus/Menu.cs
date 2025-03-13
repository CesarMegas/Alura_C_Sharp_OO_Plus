using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class Menu
{
    // Function that Draws the Title of the Chosen Option
    public void DisplayOptionTitle(string title)
    {
        // Transforms the Chosen Option's Number of Characters into a 'draw', with one line of asterisks, the option title, and a second line of asterisks
        int numberOfCharacters = title.Length;
        string asterisks = string.Empty.PadLeft(numberOfCharacters, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine($"{asterisks}\n");
    }

    public virtual void Run(Dictionary<string, Band> bandsDictionary)
    {
        Console.Clear();
    }
}
