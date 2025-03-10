namespace Alura.Filmes;

class Filme
{

    public Filme(string titulo, int duracao) 
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public List<Artista> Elenco { get; set; } = new();

    public void AdicionarArtista(Artista artista)
    {
        Elenco.Add(artista);
        artista.FilmesQueAtuou.Add(this);
    }

    public void InformacoesDoFilme()
    {
        Console.WriteLine($"Nome do Filme: {Titulo}");
        Console.WriteLine($"Duração do Filme: {Duracao} minutos");
        Console.WriteLine($"Elenco do Filme:");
        foreach (Artista artista in Elenco)
        {
            Console.WriteLine($"- {artista.Nome}");
        }
        Console.WriteLine();
    }
}
