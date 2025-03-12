namespace Atividade03.Empresa;

internal class Programador : Funcionario
{
    public Programador(string nome, double salario, string linguagemQuePrograma)
    {
        Nome = nome;
        Salario = salario;
        LinguagemQuePrograma = linguagemQuePrograma;
    }

    public string LinguagemQuePrograma { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Gerente: {Nome} / Linguagem que Programa: {LinguagemQuePrograma}");
    }
}
