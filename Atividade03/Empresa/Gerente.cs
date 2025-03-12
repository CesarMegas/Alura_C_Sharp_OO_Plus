namespace Atividade03.Empresa;

internal class Gerente : Funcionario
{
    public Gerente(string nome, double salario, string setor) 
    {
        Nome = nome;
        if (salario >= 0)
        {
            Salario = salario;
        }
        else
        {
            Console.WriteLine("Valor Insuficiente!");
        }
        Setor = setor;
    }

    public string Setor { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Gerente: {Nome} / Setor que Gerencia: {Setor}");
    }

}
