namespace Atividade04.Pagamentos;

internal class Servico : IPagavel
{
    public Servico(string nome, double taxaHoraria, int horastrabalhadas)
    {
        Nome = nome;
        TaxaHoraria = taxaHoraria;
        HorasTrabalhadas = horastrabalhadas;
    }

    public string Nome { get; }
    public double TaxaHoraria { get; set; }
    public int HorasTrabalhadas { get; set; }

    public void CalcularPagamento()
    {
        double pagamentoTotal = TaxaHoraria * HorasTrabalhadas;
        Console.WriteLine($"O Serviço {Nome} tem o Preço Total de R$ {pagamentoTotal.ToString("C2")} quando realizado por {HorasTrabalhadas} horas.");
    }
}
