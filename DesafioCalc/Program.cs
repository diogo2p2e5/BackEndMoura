int numero;
int numero2;
int resultado;

Console.WriteLine("digite o primeiro numero");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

Console.Clear();

resultado = numero + numero2;

Console.WriteLine($"resultado é igual {resultado}");

//outras formas de fazer a conta
// Console.WriteLine($"resultado de {numero} + {numero2} é {numero + numero2}");
// Console.WriteLine($"resultado de {numero} + {numero2} é {resultado}");

