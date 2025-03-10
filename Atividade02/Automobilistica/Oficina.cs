namespace Atividade02.Automobilistica;

internal class Oficina
{
    private List<Veiculo> veiculosNaOficina;
    
    public Oficina()
    {
        veiculosNaOficina = new List<Veiculo>();
    }

    public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataDoServico)
    {
        veiculosNaOficina.Add(veiculo);

        Console.WriteLine($"Serviço Agendado para o veículo: {veiculo.Marca} (Placa {veiculo.Placa}) / Data de Agendamento: {dataDoServico} / Mecânico Responsável: {mecanico.Nome}.");
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
    {
        if (veiculosNaOficina.Contains(veiculo))
        {
            Console.WriteLine($"Serviço Realizado no veículo: {veiculo.Modelo} (Placa {veiculo.Placa}) / Mecânico Responsável: {mecanico.Nome}.");
            veiculosNaOficina.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"O veículo {veiculo.Modelo} (Placa {veiculo.Placa}) não foi encontrado na oficina.");
        }
    }


}
