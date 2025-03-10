namespace Atividade02.Automobilistica;

internal class Cliente
{
    public Cliente(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }

    public string Nome { get; }
    public string Contato { get; }

    public void DetalhesDoCliente()
    {
        Console.WriteLine($"Nome: {Nome} / Contato: {Contato}");
    }
}
