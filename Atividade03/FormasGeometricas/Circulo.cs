namespace Atividade03.FormasGeometricas;

internal class Circulo : FormaGeometrica
{
    public Circulo(double r)
    {
        if (r > 0)
        {
            Raio = r;
        }
        else
        {
            Console.WriteLine("Valor Inválido!");
        }
    }

    public double Raio { get; set; }

    public override double CalcularArea()
    {
        // Cálculo: A = PI * r²
        return Math.PI * Raio * Raio;
    }

    public override double CalcularPerimetro()
    {
        // Cálculo: P = 2 * PI * r
        return 2 * Math.PI * Raio;
    }
}
