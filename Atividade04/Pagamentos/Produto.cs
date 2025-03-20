using System.Threading.Channels;

namespace Atividade04.Pagamentos;

internal class Produto : IPagavel
{
    public Produto(string nome, double precoUnitario, int quantidade)
    {
        Nome = nome;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public string Nome { get; }
    public double PrecoUnitario { get; }
    public int Quantidade { get; }

    public void CalcularPagamento()
    {
        double pagamentoTotal = PrecoUnitario * Quantidade;
        Console.WriteLine($"O Produto {Nome} tem o Preço Total de R$ {pagamentoTotal.ToString("C2")} quando comprado em {Quantidade} unidade(s).");
    }
}
