// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) 
// e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
int goltime1 = 0;
int goltime2 = 0;

Console.WriteLine("os gols do primeiro time");
goltime1 = int.Parse(Console.ReadLine());

Console.WriteLine("os gols do segundo time");
goltime2 = int.Parse(Console.ReadLine());

if (goltime1 > goltime2)
{
    Console.WriteLine($"O time um ganhou do time dois {goltime1} x {goltime2}");
}
else if (goltime2 > goltime1)
{
    Console.WriteLine($"O time dois ganhou do time um {goltime2} x {goltime1}");
}
else
{
     Console.WriteLine($"O jogo terminou em um empate {goltime1} x {goltime2}");
}