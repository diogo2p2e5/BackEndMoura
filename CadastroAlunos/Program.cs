string[] nomes = new string[3];
int[] idade = new int[3];

int opcao = -1;
int totalAlunos = 0;

do
{
    Console.WriteLine($"==== Aplcativo Sala de Aula ====");
    Console.WriteLine($"1) Listar Alunos");
    Console.WriteLine($"2) Cadastrar Alunos");
    Console.WriteLine($"3) Sair");
    Console.Write($"Escolha uma opcação: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            break;
    }




} while (opcao != 0);

void ListarAluno()
{
    Console.WriteLine($"=== Listagem de Alunos ===");

    for (int i = 0; i < totalAlunos; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}, {idade[i]} anos");




    }


}
void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastro de alunos ===");
    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;
    }

    Console.WriteLine($"Dgite o nome do Aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idade[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
    Console.WriteLine($"Aluno Cadastrado com Sucesso");

}

