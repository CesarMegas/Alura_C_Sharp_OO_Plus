namespace Atividade02.Calculadora;

internal class Calculadora
{
    public static double Calcular(double valor1, double valor2, char operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = Somar(valor1, valor2);
                break;
            case '-':
                resultado = Subtrair(valor1, valor2);
                break;
            case '*':
                resultado = Multiplicar(valor1, valor2);
                break;
            case '/':
                resultado = Dividir(valor1, valor2);
                break;
            case '^':
                resultado = Potencia(valor1, valor2);
                break;
            case 'r':
                resultado = RaizQuadrada(valor1);
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }
        return resultado;
    }

    public static double Somar(double valor1, double valor2)
    {
        return valor1 + valor2;
    }
    public static double Subtrair(double valor1, double valor2)
    {
        return valor1 - valor2;
    }
    public static double Multiplicar(double valor1, double valor2)
    {
        return valor1 * valor2;
    }
    public static double Dividir(double valor1, double valor2)
    {
        if (valor2 != 0)
        {
            return valor1 / valor2;
        }
        else
        {
            Console.WriteLine("Erro! Divisão por 0!");
            return 0;
        }
    }
    public static double Potencia(double valor1, double valor2)
    {
        return Math.Pow(valor1, valor2);
    }
    public static double RaizQuadrada(double valor1)
    {
        return Math.Sqrt(valor1);
    }

}
