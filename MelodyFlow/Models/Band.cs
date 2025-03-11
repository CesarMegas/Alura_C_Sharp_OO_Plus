namespace MelodyFlow.Models;

internal class Band
{
    private List<Album> albums = new List<Album>();
    private List<Review> reviews = new List<Review>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Average
    {
        get 
        { 
            if (reviews.Count == 0) return 0;
            else return reviews.Average(r => r.Rate);
        }
    }
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddReview(Review review)
    {
        reviews.Add(review);
    }

    public void DisplayDiscography()
    {
        Console.WriteLine($"{Name}'s Discography");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
        }
    }
}
