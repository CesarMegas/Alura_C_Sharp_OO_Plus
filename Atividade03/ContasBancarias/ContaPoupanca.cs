namespace Atividade03.ContasBancarias;

internal class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(double saldo, double taxaRendimento)
    {
        Saldo = saldo;
        TaxaRendimento = taxaRendimento;
    }

    private double TaxaRendimento { get; set; }

    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + TaxaRendimento);
    }
}
