String cargo;
double salario, salarioNovo = 0;

Console.WriteLine("Qual o seu cargo");
cargo = Console.ReadLine();

Console.WriteLine("Qual o seu salario ");
salario = float.Parse(Console.ReadLine());

if (cargo == "produção")
{

    salarioNovo = salario + (salario * 0.065);

}
else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075);
}
else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}
