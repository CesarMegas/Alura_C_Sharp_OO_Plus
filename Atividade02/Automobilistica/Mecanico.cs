namespace Atividade02.Automobilistica;

internal class Mecanico
{
    public Mecanico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public string Nome { get; }
    public string Especialidade { get; }

    public void DetalhesDoMecanico()
    {
        Console.WriteLine($"Nome: {Nome} / Especialidade: {Especialidade}");
    }
}
