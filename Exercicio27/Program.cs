int qtdnumeros = 0;
int contador = 1;

Console.WriteLine($"Digite a quantidade de números você quer digitar");
qtdnumeros = int.Parse(Console.ReadLine());

while (contador <= qtdnumeros)
{
    Console.WriteLine($"Digite um numero:");
    int batata = int.Parse(Console.ReadLine());

    if (batata % 2 == 0)
    {

        Console.WriteLine($"O numero eh par: {batata}");


    }
    contador++;
}



