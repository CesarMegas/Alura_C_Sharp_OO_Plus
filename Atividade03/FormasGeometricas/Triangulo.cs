namespace Atividade03.FormasGeometricas;

internal class Triangulo : FormaGeometrica
{
    public Triangulo(double b, double h)
    {
        if (b > 0 && h > 0)
        {
            Base = b;
            Altura = h;
        }
        else
        {
            Console.WriteLine("Valor Inválido!");
        }
    }


    public double Base { get; }
    public double Altura { get; }

    public override double CalcularArea()
    {
        // Cálculo: 
        return (Base * Altura) / 2;
    }

    public override double CalcularPerimetro()
    {
        // Cálculo: A = b + h + c
        return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}
