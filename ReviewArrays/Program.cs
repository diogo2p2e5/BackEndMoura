string[] nomes = new string[4];

nomes[0] = "Edu";
nomes[1] = "Márico";
nomes[2] = "Manoel";



Console.WriteLine($"1o nome: {nomes[0]}");
Console.WriteLine($"2o nome: {nomes[1]}");
Console.WriteLine($"3o nome: {nomes[2]}");
Console.WriteLine($"4o nome: {nomes[3]}");
Console.WriteLine($"5o nome: {nomes[4]}");

Console.WriteLine($"Tamanho Array: {nomes.Length}");


for (int i = 0; i < nomes.Length; i++)
{
Console.WriteLine($" {i}o Nome: {nomes[0]}");

}