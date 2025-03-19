namespace Atividade04.FormasGeometricas;

internal class Circulo : IForma
{
    public Circulo(double raio) 
    {
        if (raio > 0)
        {
            Raio = raio;
        }
        else
        {
            Console.WriteLine("Valor Inválido!");
        }
    }

    public double Raio { get; }

    public void CalcularArea()
    {
        double area = Math.PI * Raio * Raio;
        Console.WriteLine($"O valor da Área desse Círculo é de: {area.ToString("F2")}.");
    }

    public void CalcularPerimetro()
    {
        double perimetro = 2 * Math.PI * Raio;
        Console.WriteLine($"O valor do Perímetro desse Círculo é de: {perimetro.ToString("F2")}.");
    }
}
