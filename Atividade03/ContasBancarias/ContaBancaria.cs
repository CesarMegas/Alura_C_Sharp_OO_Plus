namespace Atividade03.ContasBancarias;

internal class ContaBancaria
{
    protected double Saldo { get; set; }

    public virtual void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado! Saldo Atual: R$ {Saldo:C}.\n");
        }
        else
        {
            Console.WriteLine("Valor Inválido!\n");
        }
    }

    public virtual void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} realizado! Saldo Atual: R$ {Saldo:C}");
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente!");
        }
        
    }

    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}
