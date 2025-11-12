
using PrimeiraClasse;

// Console.WriteLine($"===== PROGRAMA PRIMEIRA CLASSE =====");

// // Carro mistubishi = new Carro();
// // mistubishi.marca = "Mitsubishi";
// // mistubishi.modelo = "Lancer";
// // mistubishi.cor = "Prata";
// // mistubishi.potencia = 160;

// // Console.WriteLine($"Ligando o {mistubishi.marca} {mistubishi.cor}");
// // mistubishi.Ligar();

// // Console.WriteLine($"Acelerando o {mistubishi.marca} de {mistubishi.potencia} cv");
// // mistubishi.Acelerar();


// // Pessoa max = new Pessoa();
// // max.Nome = "Max Verstappen";
// // max.Idade = 28;
// // max.campeonatos = "4";

// // Console.WriteLine($"{max.Nome} de {max.Idade} já ganhou {max.campeonatos} campeonatos e com certeza");
// // max.habilidade();
// // Console.WriteLine($"{max.Nome} tambem fala");
// // max.fala();



Pessoa diogo = new Pessoa();
diogo.Nome = "Diogo";
diogo.Idade = 16;
diogo.Altura = 175;

Console.WriteLine($"{diogo.Nome} tem {diogo.Idade} anos");
diogo.envelhecer(10);
Console.WriteLine($"{diogo.Nome} tem {diogo.Idade} anos");


