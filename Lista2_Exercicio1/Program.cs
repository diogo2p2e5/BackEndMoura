// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido
//  na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e 
// “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

float salario = 0;
float gastos = 0;

Console.WriteLine("Informe o seu salário");
salario = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o seus gastos");
gastos = float.Parse(Console.ReadLine());

if (gastos < salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else if (gastos > salario)
{
    Console.WriteLine("Orçamento estourado");
}
else
{
    Console.WriteLine("Orçamento inválido");
}

