namespace Atividade02.PetShop;

internal class Medico
{
    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public string Nome { get; }
    public string Especialidade { get; set; }

    public void DetalhesDoMedico()
    {
        Console.WriteLine($"Nome: {Nome} / Especialidade: {Especialidade}");
    }
}
