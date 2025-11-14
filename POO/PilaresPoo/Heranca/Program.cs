
using Exercicio1;
using Exercicio2;
using Heranca;

// cachorro thor = new cachorro();
// thor.fazersom();

// gato tofu = new gato();
// tofu.fazersom();


// Funcionario jim = new Funcionario();
// jim.Nome = "Jim Halpert";
// Console.WriteLine($"o funcionario {jim.Nome} tem o salario de {jim.salariobase}");

// Gerente Michal = new Gerente();
// Michal.Nome = "Michael Scott";
// Console.WriteLine($"O gerente {Michal.Nome} tem o salario de {Michal.CalcularSalario}");


// Carro uno = new Carro();
// uno.Marca = "Fiat";
// uno.Modelo = "uno";
// uno.Ano = 1984;
// uno.QtdPortas = 4;
// uno.acelera();

// Moto moto = new Moto();
// moto.Marca = "suzuki";
// moto.Modelo = "V-Storm";
// moto.Ano = 2004;
// moto.somdamoto();

// Aviao aviao = new Aviao();
// aviao.Marca = "Boeing";
// aviao.Modelo = "F/A-18E/F Super Hornet";
// aviao.destino = "Itália";
// aviao.voar();

// Aluno robes = new Aluno();
// robes.Nome = "Robertinho";
// robes.Idade = 17;
// robes.Curso = "Soldador";
// Console.WriteLine($"O aluno {robes.Nome} de {robes.Idade} anos faz o curso {robes.Curso}");


// Professor junis = new Professor();
// junis.Nome = "Junior";
// junis.Idade = 45;
// junis.diciplina = "Metalurgia";
// Console.WriteLine($" o professor {junis.Nome} de {junis.Idade} anos da a disciplina de {junis.diciplina}");

// Conta ca = new Conta();
// ca.saldo = 1500;
// ca.valor = 500;
// ca.depositar();
// Console.WriteLine($" valor depositado {ca.saldo}");
// ca.sacar();
// Console.WriteLine($" valor sacado {ca.valor}");

Contapoupanca cp = new Contapoupanca();
cp.saldo = 1500;
cp.valor = 500;
cp.CalcularRendimento();
Console.WriteLine($"o saldo da conta {cp.saldo}");



