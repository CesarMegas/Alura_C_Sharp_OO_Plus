using MelodyFlow.Models;

namespace MelodyFlow.Menus;

internal class MenuEndProgram : Menu
{
    //Function that Ends the Program
    public override void Run(Dictionary<string, Band> bandsDictionary)
    {
        base.Run(bandsDictionary);
        Console.WriteLine("End of Program!");
    }
}
