int qtdNumeros = 0;

Console.WriteLine($"Quantos números você quer digitar");
qtdNumeros = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "Ímpares: ";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}° número: ");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}
Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);