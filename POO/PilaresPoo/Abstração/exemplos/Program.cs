using System.Data.SqlTypes;
using exemplos;
// Gato bisteca = new Gato();
// bisteca.Fazersom();
// bisteca.Mover();

// Cachorro Thor = new Cachorro();
// Thor.Fazersom();
// Thor.Mover();

// Pessoa Roberto = new Pessoa();
// Roberto.Nome = "Robertinho";
// Roberto.idade = 23;
// Roberto.Fazersom();
// Roberto.Mover();
// Roberto.Dormir();

Console.Clear();


ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"O saldo atual da conta é {cc.saldo}");
cc.Despositar(0.5);
Console.WriteLine($"O saldo após o depósito da conta é {cc.saldo}");
cc.Sacar(10);
Console.WriteLine($"O saldo após o saque da conta é {cc.saldo:F2}");

Console.WriteLine();

ContaPoupança cp = new ContaPoupança(10);
Console.WriteLine($"O saldo atual da conta é {cp.saldo}");
cp.Despositar(0.5);
Console.WriteLine($"O saldo após o depósito da conta é {cp.saldo}");
cp.Sacar(10);
Console.WriteLine($"O saldo após o saque da conta é {cp.saldo:F2}");
