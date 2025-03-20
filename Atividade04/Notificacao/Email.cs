namespace Atividade04.Notificacao;

internal class Email : INotificavel
{
    public Email(string titular, string enderecoDeEmail)
    {
        Titular = titular;
        EnderecoDeEmail = enderecoDeEmail;
    }

    public string Titular { get; }
    public string EnderecoDeEmail { get; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Mensagem para {Titular} ({EnderecoDeEmail}): Seu e-mail está protegido!");
    }
}
