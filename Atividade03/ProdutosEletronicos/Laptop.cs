namespace Atividade03.ProdutosEletronicos;

internal class Laptop : ProdutoEletronico
{
    public Laptop(string modelo, double preco, string processador)
    {
        Modelo = modelo;
        Preco = preco;
        Processador = processador;
    }

    public string Processador { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Processador: {Processador}";
    }
}
