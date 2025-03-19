namespace Atividade04.FormasGeometricas;

internal class Retangulo : IForma
{
    public Retangulo(double baseRetangulo, double alturaRetangulo)
    {
        if (baseRetangulo > 0 && alturaRetangulo > 0)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }
        else
        {
            Console.WriteLine("Valor Inválido!");
        }
    }

    public double Base { get; }
    public double Altura { get; }

    public void CalcularArea()
    {
        // Cálculo da Área: Base^2 * Altura^2
        double area = Math.Pow(Base, 2) * Math.Pow(Altura, 2);
        Console.WriteLine($"A Área deste Retângulo é igual a: {area}.");
    }

    public void CalcularPerimetro()
    {
        // Cálculo do Perímetro
        double perimetro = (Base * 2) + (Altura * 2);
        Console.WriteLine($"O Perímetro deste Retângulo é igual a: {perimetro}.");
    }
}
