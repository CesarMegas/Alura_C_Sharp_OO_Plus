// Atividade 03 - Comportamentos Comuns aos Menus
// Exercício 01 - Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.

// Exercício 02 - Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

// Exercício 03 - Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

// Exercício 04 - Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

// Exercício 05 - Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

using Atividade03.Animais;
using Atividade03.ContasBancarias;
using Atividade03.Empresa;
using Atividade03.FormasGeometricas;
using Atividade03.ProdutosEletronicos;

// FORMAS GEOMÉTRICAS
// Quadrado
FormaGeometrica quadrado1 = new Quadrado(5);
double areaDoQuadrado = quadrado1.CalcularArea();
double perimetroDoQuadrado = quadrado1.CalcularPerimetro();

Console.WriteLine($"Área do Quadrado: {areaDoQuadrado}");
Console.WriteLine($"Perímetro do Quadrado: {perimetroDoQuadrado}");
Console.WriteLine();

// Triângulo
FormaGeometrica triangulo1 = new Triangulo(3, 4);
double areaDoTriangulo = triangulo1.CalcularArea();
double perimetroDoTriangulo = triangulo1.CalcularPerimetro();

Console.WriteLine($"Área do Triângulo: {areaDoTriangulo}");
Console.WriteLine($"Perímetro do Triângulo: {perimetroDoTriangulo}");
Console.WriteLine();

// Círculo
FormaGeometrica circulo1 = new Circulo(5);
double areaDoCirculo = circulo1.CalcularArea();
double perimetroDoCirculo = circulo1.CalcularPerimetro();

Console.WriteLine($"Área do Círculo: {areaDoCirculo}");
Console.WriteLine($"Perímetro do Círculo: {perimetroDoCirculo}");
Console.WriteLine();

// EMPRESA
// Gerente
Gerente gerente1 = new ("Ricardo", 10000, "Marketing");
gerente1.ExibirInformacoes();
Console.WriteLine();

// Programador
Programador programador1 = new("Guilherme", 2000, "C#");
programador1.ExibirInformacoes();
Console.WriteLine();

// Analista
Analista analista1 = new("Felipe", 4000, "Financeiro");
analista1.ExibirInformacoes();
Console.WriteLine();

// CONTAS BANCÁRIAS
// Conta Corrente
ContaBancaria conta1 = new ContaCorrente(5000, 10);
conta1.Depositar(1000);
conta1.Sacar(2000);

// Conta Poupança
ContaBancaria conta2 = new ContaPoupanca(5000, 1);
conta2.Depositar(1000);
double saldoComLucro = conta2.CalcularSaldo();
Console.WriteLine($"Saldo da Conta: {saldoComLucro:C}");
Console.WriteLine();

// ANIMAIS
// Mamífero
Animal mamifero = new Mamifero();
string somMamifero = mamifero.EmitirSom();
Console.WriteLine(somMamifero);
Console.WriteLine();

// Ave
Animal ave = new Ave();
string somAve = ave.EmitirSom();
Console.WriteLine(somAve);
Console.WriteLine();

// Peixe
Animal peixe = new Peixe();
string somPeixe = peixe.EmitirSom();
Console.WriteLine(somPeixe);
Console.WriteLine();

//PRODUTOS ELETRONICOS
//Smartphone
ProdutoEletronico smartphone = new Smartphone("Samsung Galaxy S24", 6000, "Android");
string informacoesSmartphone = smartphone.ExibirInformacoes();
Console.WriteLine(informacoesSmartphone);
Console.WriteLine();

//Tablet
ProdutoEletronico tablet = new Tablet("Samsung Galaxy Tab S10", 6000, "AMOLED Dinâmico 2X");
string informacoesTablet = tablet.ExibirInformacoes();
Console.WriteLine(informacoesTablet);
Console.WriteLine();

//Laptop
ProdutoEletronico laptop = new Laptop("Alienware m16 R2", 16000, "Intel® Core™ Ultra 9 185H");
string informacoesLaptop = laptop.ExibirInformacoes();
Console.WriteLine(informacoesLaptop);
Console.WriteLine();
