namespace MelodyFlow.Models;

class Music

{
    public Music(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string ShortDescription => $"The Song {Name} belongs to the band {Artist}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (Available)
        {
            Console.WriteLine("Available in the Current Subscription!");
        }
        else
        {
            Console.WriteLine("Unavailable in the Current Subscription...");
        }
    }
}
