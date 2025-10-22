int n1;
int n2;

Console.WriteLine("digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o primeiro numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
Console.WriteLine($"o numero {n1} é maior que o {n2}");
}


else if (n2 > n1)
{
    Console.WriteLine($"o numero {n2} é maior que o {n1}");
}

else
{
        Console.WriteLine($"os numeros são iguais");
}