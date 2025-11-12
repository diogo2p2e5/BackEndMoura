using ClassesEObjetos;

Console.Clear();
// ContaBancaria conta = new ContaBancaria();
// conta.Titular = "Diogo";
// conta.Saldo = 1500.98f;


// Console.WriteLine($"{conta.Titular} sua conta tem R${conta.Saldo}");


// conta.Depositar(500);

// conta.sacar(350);

// Garrafa garrafinha = new Garrafa();
// garrafinha.capacidade = 500;
// garrafinha.material = "Plastico";
// garrafinha.marca = "crystal";

// Console.WriteLine($"a garrafa {garrafinha.marca} tem {garrafinha.capacidade}ml de capacidade e é feita de {garrafinha.material}");
// garrafinha.encher();
// garrafinha.esvaziar();


Produto salgadinho = new Produto();
salgadinho.Nome = "Doritos";
salgadinho.Preco = 12.40;

Console.WriteLine($"{salgadinho.Nome} custa R${salgadinho.Preco}");

salgadinho.AplicarDesconto(20);

