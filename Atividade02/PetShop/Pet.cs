namespace Atividade02.PetShop;

internal class Pet
{
    public Pet(string nome, int idade, string raca)
    {
        Nome = nome;
        Idade = idade;
        Raca = raca;
    }

    public string Nome { get; }
    public int Idade { get; }
    public string Raca { get; }

    public void DetalhesDoPet()
    {
        Console.WriteLine($"Nome: {Nome} / Idade: {Idade} ano(s) / Raça: {Raca}");
    }

}
