// Atividade 04 - Alternativa para Anexar Semelhanças
// Exercício 01 - Criar uma interface chamada IForma que declare métodos para calcular a área e o perímetro de uma forma geométrica. Implemente esta interface em duas classes: Circulo e Retangulo.

// Exercício 02 - Criar duas interfaces adicionais, IPilotavel e IVoavel. Implemente essas interfaces na classe Veiculo.

// Exercício 03 - Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

// Exercício 04 - Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

// Exerxício 05 - Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

using Atividade04.Armazenamento;
using Atividade04.FormasGeometricas;
using Atividade04.Notificacao;
using Atividade04.Pagamentos;
using Atividade04.Veiculos;

// FORMAS GEOMÉTRICAS
// Círculo
Circulo circulo1 = new(3);

circulo1.CalcularArea();
circulo1.CalcularPerimetro();
Console.WriteLine();

// Retângulo
Retangulo retangulo1 = new(4, 2);

retangulo1.CalcularArea();
retangulo1.CalcularPerimetro();
Console.WriteLine();

// VEÍCULOS
// Pilotável
Veiculo veiculo1 = new("Bugatti Chiron");
veiculo1.Pilotar(420);
Console.WriteLine();

Veiculo veiculo2 = new("Bombardier Global Express");
veiculo2.Voar(15000);
Console.WriteLine();

// PAGAMENTOS
// Produtos
Produto produto1 = new("Café 3 Corações", 35, 2);
produto1.CalcularPagamento();
Console.WriteLine();

// Serviços
Servico servico1 = new("Pedreiro", 15, 8);
servico1.CalcularPagamento();
Console.WriteLine();

// NOTIFICAÇÕES
// SMS
SMS numero1 = new("Roger", "11 9 1234-5678");
numero1.EnviarNotificacao();
Console.WriteLine();

// E-mail
Email email1 = new("Roger", "rogeremail@gmail.com");
email1.EnviarNotificacao();
Console.WriteLine();

// ARMAZENAMENTO
// Arquivo
Arquivo arquivo1 = new("Foto de Casamento.jpg", 10);
Arquivo arquivo2 = new("Jogo de Cartas", 150);

arquivo1.Salvar();
arquivo2.Recuperar();
Console.WriteLine();

//Banco de Dados
BancoDeDados bancoDeDados1 = new("Contas Bancárias");
BancoDeDados bancoDeDados2 = new("Fotos de Bebê");

bancoDeDados1.Salvar();
bancoDeDados2.Recuperar();
