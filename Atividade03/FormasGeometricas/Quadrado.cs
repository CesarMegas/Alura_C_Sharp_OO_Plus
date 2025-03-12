namespace Atividade03.FormasGeometricas;

internal class Quadrado : FormaGeometrica
{
    public Quadrado(double l)
    {
        if (l > 0)
        {
            Lado = l;
        }
        else
        {
            Console.WriteLine("Valor Inválido!");
        }
       
    }


    public double Lado { get; }

    public override double CalcularArea()
    {
        // Cálculo: A = Lado * Lado
        return Lado * Lado; 
    }

    public override double CalcularPerimetro()
    {
        // Cálculo: P = 4 * Lado
        return 4 * Lado;
    }
}
