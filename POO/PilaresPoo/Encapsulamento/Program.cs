using Encapsulamento;

// ContaBancaria diogo = new ContaBancaria();

// diogo.Depositar(100);
// diogo.Depositar(20);
// diogo.Sacar(50);


// Console.WriteLine($"Saldo atual: {diogo.GetSaldo()}");

Carro fuzca = new Carro();

fuzca.Acelerar(100);
fuzca.Frear(20);
fuzca.DefinirMarca("volkswagen");

Console.WriteLine($"Marca do carro: {fuzca.ObterMarca()}");
// Console.WriteLine($"Modelo do carro: {fuzca.ObterModelo()}");
Console.WriteLine($"");
Console.WriteLine($"Velocidade atual: {fuzca.ObterVelocidade()}km/h");


