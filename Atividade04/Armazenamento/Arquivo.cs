namespace Atividade04.Armazenamento;

internal class Arquivo : IArmazenavel
{
	public Arquivo(string nome, double tamanho)
	{
		Nome = nome;
		Tamanho = tamanho;
	}

    public string Nome { get; }
    public double Tamanho { get; }

    public void Recuperar()
    {
        Console.WriteLine($"O Arquivo {Nome} ({Tamanho} MB) foi Recuperado com sucesso!");
    }

    public void Salvar()
    {
        Console.WriteLine($"O Arquivo {Nome} ({Tamanho} MB) foi Salvo com sucesso!");
    }
}
