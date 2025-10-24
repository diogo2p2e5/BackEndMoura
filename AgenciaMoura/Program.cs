using System.Numerics;
using System.Runtime.Serialization.Formatters;

int opcao = -1;
string[] nomes = new string[10];
float[] saldo = new float[10];
int totalClientes = 0;



do
{
    Console.WriteLine(@$"=== SISTEMA BANCÁRIO SIMPLES ===
                            
     1. Cadastrar Cliente
     2. Depositar
     3. Sacar
     4. Tranferir
     5. Listar clientes
     0. Sair
");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            // Sacar();
            break;
        case 4:
            // Tranferir();
            break;
        case 5:
            // ListarClientes();
            break;





        default:
            break;
    }



    Console.WriteLine($"Pressione ENTER para continuar");
    Console.WriteLine();

} while (opcao != 0);


void CadastrarCliente()
{
    Console.WriteLine($"=== CADASTRE O CLIENTE ===");
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de cadastros atingido");
        return;
    }

    Console.WriteLine($"Digite o nome do cliente");
    nomes[totalClientes] = Console.ReadLine();
    saldo[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine($"O cliente foi cadastrado com sucesso!");

}
void Depositar()
{
    Console.WriteLine($"=== DEPOSITE EM UMA CONTA ===");
    for (int i = 0; i < totalClientes; i++)
    {
         Console.WriteLine($"{i} - {nomes[i]} | saldo: R${saldo[i]}");
    }


}
void ListarClientes()
{
    Console.WriteLine($"== LISTA DE CLIENTES ==");

    System.Console.WriteLine($"");



}