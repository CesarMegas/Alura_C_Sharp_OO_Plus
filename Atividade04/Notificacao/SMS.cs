namespace Atividade04.Notificacao;

internal class SMS : INotificavel
{
    public SMS(string titular, string numeroDeTelefone)
    {
        Titular = titular;
        NumeroDoTelefone = numeroDeTelefone;
    }

    public string Titular { get; }
    public string NumeroDoTelefone { get; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Mensagem para {Titular} ({NumeroDoTelefone}): Seu número está protegido!");
    }
}
