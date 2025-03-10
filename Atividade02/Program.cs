// Atividade 02 - Nova Classe Avaliação
// Exercício 01 - Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

//Exercício 02 - Modelar o funcionamento de uma oficina automobilistica.

// Exercício 03 - Criar um programa Program.cs e simular o funcionamento do programa.

//Exercício 04 - Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

using Atividade02.Automobilistica;
using Atividade02.Calculadora;
using Atividade02.PetShop;

class Program
{
    static void Main()
    {
        //PetShop
        Pet pet1 = new("Haru", 1, "Gato Vira-lata");
        Dono dono1 = new("Bruno", "emailDoBruno@gmail.com");
        Medico medico1 = new("Magali", "Clínica Geral");
        Consulta consulta1 = new(pet1, dono1, medico1, "24/01/2025 - 13:45");

        //Automobilistica
        Veiculo veiculo1 = new("Dodge", "Dodge Challenger", 1970, "ABC1234");
        Cliente cliente1 = new("Afonso", "emailDoAfonso@gmail.com");
        Mecanico mecanico1 = new("Cleverson", "Motores");
        Oficina oficina1 = new();

        oficina1.AgendarServico(veiculo1, cliente1, mecanico1, "26/02/2025 - 13:00");
        oficina1.RealizarServico(veiculo1, mecanico1);
        Console.WriteLine();

        //Calculadora
        double resultado1 = Calculadora.Calcular(25, 5, 'r');
        Console.WriteLine(resultado1);
    }
}
