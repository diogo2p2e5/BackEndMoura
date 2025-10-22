float nota1, nota2, nota3, nota4, media;


Console.WriteLine("digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a segunda nota");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a terceira nota");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a quarta nota");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;


if (media >= 7)
{
    Console.WriteLine("APROVADO");
}
else if (media >= 5)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}