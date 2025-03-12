namespace Atividade03.ProdutosEletronicos;

internal class Tablet : ProdutoEletronico
{
    public Tablet(string modelo, double preco, string tipoTela)
    {
        Modelo = modelo;
        Preco = preco;
        TipoTela = tipoTela;
    }

    public string TipoTela { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Tela: {TipoTela}";
    }
}
