namespace Atividade04.Veiculos
{
    internal class Veiculo : IPilotavel, IVoavel
    {
        public Veiculo(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public void Pilotar(double velocidade)
        {
            Console.WriteLine($"O Veículo {Nome} dirige com velocidade máxima de {velocidade} Km/h.");
        }

        public void Voar(double altura)
        {
            Console.WriteLine($"O Veículo {Nome} pode voar até {altura} metros.");
        }
    }
}
