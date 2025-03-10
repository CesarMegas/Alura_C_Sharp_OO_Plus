namespace Atividade02.PetShop;

internal class Dono
{
    public Dono(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }

    public string Nome { get; }
    public string Contato { get; }

    public void DetalhesDoDono()
    {
        Console.WriteLine($"Nome: {Nome} / Contato: {Contato}");
    }
}
