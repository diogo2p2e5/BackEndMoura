int senha = 1234;

Console.Write($"Digite a Senha: ");
senha = int.Parse(Console.ReadLine());

if (senha != 1234)
{
    Console.WriteLine($"ACESSO  NEGADO");

} else if (senha == 1234)
{
    Console.WriteLine($"ACESSO  PERMITIDO ");

}
else
{
    Console.WriteLine($"ACESSO  NEGADO");
    
}