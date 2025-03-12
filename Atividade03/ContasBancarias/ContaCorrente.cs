namespace Atividade03.ContasBancarias;

internal class ContaCorrente : ContaBancaria
{
    public ContaCorrente(double saldo, double taxaDeManutencao)
    {
        Saldo = saldo;
        TaxaManutencao = taxaDeManutencao;
    }

    private double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }
}
