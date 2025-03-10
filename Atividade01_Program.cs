// Atividade 01 - Organizando o Programa
// Exercício 01 - Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

// Exercício 02 - Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.

// Exercício 03 - Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

//Exercício 04 - Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

using Alura.Filmes;

List<Filme> filmes = new List<Filme>();

//CRIANDO OS FILMES
Filme dalmatas = new("101 Dálmatas (1961)", 79);
Filme ratinhoDetetive = new("As Peripécias de um Ratinho Detetive", 74);
Filme vingadores = new("Vingadores: Ultimato", 181);
Filme divertidamente2 = new("Divertidamente 2", 96);
Filme operacaoBigHero = new("Operação Big Hero", 108);//", , "

//**CRIANDO OS ARTISTAS
//101 Dálmatas (1961)
Artista bettyLouGerson = new("Betty Lou Gerson (Cruella)", 84);
Artista cateBauer = new("Cate Bauer (Perdita)", 90);
Artista rodTaylor = new("Rod Taylor (Pongo)", 84);

//As Peripécias de um Ratinho Detetive
Artista barrieIngham = new("Barrie Ingham (Basil da Rua Baker)", 82);
Artista valBettin = new("Val Bettin (Dr. David Q. Dawson)", 97);
Artista vincentPrice = new("Vincent Price (Professor Ratagão)", 82);

//Vingadores: ULTIMATO
Artista robertDowneyJr = new("Robert Downey Jr. (Homem de Ferro)", 59);
Artista chrisEvans = new("Chris Evans (Capitão América)", 43);
Artista scarlettJohansson = new("Scarlett Johansson (Viúva Negra)", 40);

//Divertidamente 2
Artista amyPoehler = new("Amy Poehler (Alegria)", 53);
Artista phyllisSmith = new("Phyllis Smith (Tristeza)", 75);
Artista mayaHawke = new("Maya Hawke (Ansiedade)", 26);

//Operação Big Hero
Artista ryanPotter = new("Ryan Potter (Hiro Hamada)", 29);
Artista scottAdsit = new("Scott Adsit (Baymax)", 59);
Artista stanLee = new("Stan Lee (Pai do Fred)", 95);

//**ADICIONANDO OS ARTISTAS
//101 Dálmatas (1961)
dalmatas.AdicionarArtista(bettyLouGerson);
dalmatas.AdicionarArtista(cateBauer);
dalmatas.AdicionarArtista(rodTaylor);

//As Peripécias de um Ratinho Detetive
ratinhoDetetive.AdicionarArtista(barrieIngham);
ratinhoDetetive.AdicionarArtista(valBettin);
ratinhoDetetive.AdicionarArtista(vincentPrice);

//Vingadores:ULTIMATO
vingadores.AdicionarArtista(robertDowneyJr);
vingadores.AdicionarArtista(chrisEvans);
vingadores.AdicionarArtista(scarlettJohansson);

//Divertidamente 2
divertidamente2.AdicionarArtista(amyPoehler);
divertidamente2.AdicionarArtista(phyllisSmith);
divertidamente2.AdicionarArtista(mayaHawke);

//Operação Big Hero
operacaoBigHero.AdicionarArtista(ryanPotter);
operacaoBigHero.AdicionarArtista(scottAdsit);
operacaoBigHero.AdicionarArtista(stanLee);

//**ADICIONANDO OS FILMES
filmes.Add(dalmatas);
filmes.Add(ratinhoDetetive);
filmes.Add(vingadores);
filmes.Add(divertidamente2);
filmes.Add(operacaoBigHero);

//**INFORMAÇÕES DOS FILMES
dalmatas.InformacoesDoFilme();
ratinhoDetetive.InformacoesDoFilme();
vingadores.InformacoesDoFilme();
divertidamente2.InformacoesDoFilme();
operacaoBigHero.InformacoesDoFilme();
