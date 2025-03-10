namespace MelodyFlow.Models;

class Band
{
    private List<Album> albums = new List<Album>();
    private List<int> reviews = new List<int>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Average => reviews.Average();
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddReview(int review)
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
