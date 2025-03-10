namespace Alura.Filmes;

class Artista
{
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> FilmesQueAtuou { get; set; } = new();
}
