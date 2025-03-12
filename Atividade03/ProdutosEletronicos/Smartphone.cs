namespace Atividade03.ProdutosEletronicos;

internal class Smartphone : ProdutoEletronico
{
    public Smartphone(string modelo, double preco, string sistemaOperacional)
    {
        Modelo = modelo;
        Preco = preco;
        SistemaOperacional = sistemaOperacional;
    }

    public string SistemaOperacional { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Sistema Operacional: {SistemaOperacional}";
    }
}
