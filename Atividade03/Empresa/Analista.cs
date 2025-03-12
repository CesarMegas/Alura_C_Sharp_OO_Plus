namespace Atividade03.Empresa;

internal class Analista : Funcionario
{
    public Analista(string nome, double salario, string areaDeAtuacao)
    {
        Nome = nome;
        Salario = salario;
        AreaDeAtuacao = areaDeAtuacao;
    }

    public string AreaDeAtuacao { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Gerente: {Nome} / Área em que Atua: {AreaDeAtuacao}");
    }
}
