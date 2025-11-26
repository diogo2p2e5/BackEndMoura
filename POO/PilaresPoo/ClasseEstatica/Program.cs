using System.Runtime.InteropServices;
using ClasseEstatica;

// CalculosMatematicos Calc = new CalculosMatematicos();
Console.WriteLine($"O numero pi é igual a: {CalculosMatematicos.PI}");

Console.Write($"Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.Write($"Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Resultados");
// Console.WriteLine($"Soma: {CalculosMatematicos.somar(n1, n2)}");
// Console.WriteLine($"Subtração: {CalculosMatematicos.subtracao(n1, n2)}");
// Console.WriteLine($"Divisão: {CalculosMatematicos.divisao(n1, n2)}");
// Console.WriteLine($"Multiplicação: {CalculosMatematicos.multiplicacao(n1, n2)}");

Console.WriteLine($"o Numero maior é: {Math.Max(n1, n2)}");
Console.WriteLine($"o Numero menor é: {Math.Min(n1, n2)}");
