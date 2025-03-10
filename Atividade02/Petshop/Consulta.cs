namespace Atividade02.PetShop;

internal class Consulta
{
    public Consulta(Pet pet, Dono dono, Medico medico, string data)
    {
        Pet = pet;
        Dono = dono;
        Medico = medico;
        Data = data;
    }

    public Pet Pet { get; set; }
    public Dono Dono { get; set; }
    public Medico Medico { get; set; }
    public string Data { get; set; }

    public void DetalhesDaConsulta()
    {
        Console.WriteLine($"Data da Consulta: {Data} / Médico: {Medico} / Pet e Dono: {Pet} e {Dono}.");
    }

}
