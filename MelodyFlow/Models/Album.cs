namespace MelodyFlow.Models;

internal class Album : IRatable
{
    private List<Music> songs = new List<Music>();
    private List<Review> reviews = new List<Review>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => songs.Sum(m => m.Duration);
    public IEnumerable<Music> Songs => songs;

    public double Average 
    { 
        get
        {
            if (reviews.Count == 0) return 0;
            else return reviews.Average(a => a.Rate);
        } 
    }

    public void AddSong(Music song)
    {
        songs.Add(song);
    }

    public void AddReview(Review review) 
    {
        reviews.Add(review);
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
