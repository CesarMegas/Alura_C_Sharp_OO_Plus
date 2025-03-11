namespace MelodyFlow.Models;

internal class Album
{
    private List<Music> songs = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => songs.Sum(m => m.Duration);
    public List<Music> Songs => songs;

    public void AddSong(Music song)
    {
        songs.Add(song);
    }

    public void DisplayAlbumSongs()
    {
        Console.WriteLine($"{Name}'s Songs:\n");
        foreach (var song in songs)
        {
            Console.WriteLine($"Song: {song.Name}");
        }
        Console.WriteLine($"\nListening to the entire Almbum takes {TotalDuration}");
    }
}
