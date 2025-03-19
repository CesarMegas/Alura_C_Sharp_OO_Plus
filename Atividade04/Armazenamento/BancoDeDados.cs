namespace Atividade04.Armazenamento;

internal class BancoDeDados : IArmazenavel
{
    public BancoDeDados(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando os Dados de {Nome}...");
    }

    public void Salvar()
    {
        Console.WriteLine($"Salvando os Dados de {Nome}!");
    }
}
