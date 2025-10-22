//pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario, e quanto investiu no ano
string nome;
string sobrenome;
int idade;
float saldobancario;
float investimentos;

Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenome = Console.ReadLine();

Console.WriteLine("Qual é o sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o saldo bancário?");
saldobancario = float.Parse(Console.ReadLine());

Console.WriteLine("Qual foi seu total investido?");
investimentos = float.Parse(Console.ReadLine());


Console.Clear();//limpa o console
Console.WriteLine($"Nome: {nome} {sobrenome}");
// Console.WriteLine("Nome: " + nome + " " + sobrenome );
Console.WriteLine($"idade do {nome} é {idade} ");
// Console.WriteLine("idade: " + idade);
Console.WriteLine($"saldo bancário: {saldobancario}");
// Console.WriteLine("saldo bancário: " + saldobancario);
Console.WriteLine($"investimentos este ano: {investimentos} ");
// Console.WriteLine("investimentos: " + investimentos);