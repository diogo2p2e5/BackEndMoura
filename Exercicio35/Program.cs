using System.ComponentModel;
int contador = 1;
int repeticoes = 0;

Console.WriteLine($"Digite o numero de vezes que quer repetir A contagem");
repeticoes = int.Parse(Console.ReadLine());

while (contador <= repeticoes)
{

    Console.WriteLine("Digite um numero");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um segundo numero");
    int n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($" {n1} eh maior que {n2}");

    }
    else if (n2 > n1)
    {

        Console.WriteLine($" {n2} eh maior que {n1}");

    }
    else
    {
        Console.WriteLine($"os numeros são iguais");
    }
    contador++;
}