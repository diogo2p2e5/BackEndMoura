using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;


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
            Sacar();
            break;
        case 4:
            Tranferir();
            break;
        case 5:
            ListarClientes();
            break;





        default:
            Console.WriteLine($"Opção inválida");

            break;
    }//fim do switch


    //ao final de cada opção, faz uma parada no sistema
    Console.WriteLine($"Pressione ENTER para continuar");
    Console.WriteLine();

} while (opcao != 0);


void CadastrarCliente()

{
    Console.WriteLine($"=== CADASTRE O CLIENTE ===");
    //validar se há espaço para cadastrar no array
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de cadastros atingido");
        return;//para a função aqui - não executa o código abaixo
    }
    //cadastrar o cliente no array - 0
    Console.Write($"Digite o nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();//cadastra o nome do cliente
    saldo[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine($"O cliente foi cadastrado com sucesso!");

}
void Depositar()
{
    int idCliente = BuscarCliente();//retorna o índice do array que o cliente está armazenado

    if (idCliente == -1)
    {
        return;
    }
    Console.Write($"Valor de depósito: ");
    float valor = float.Parse(Console.ReadLine());
    saldo[idCliente] += valor;
    Console.WriteLine($"Deposito de R${valor:F2} realizado");

   
}

void ListarClientes()



{
    Console.WriteLine($"== LISTA DE CLIENTES ==");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nomes[i]} | saldo: R${saldo[i]}");
    }



}
void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Qual o valor para o saque: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldo[idCliente] >= valor && valor > 0)
    {
        saldo[idCliente] -= valor;
        Console.WriteLine($"Saque realizado com sucesso!");
        
    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");
    }

}
void Tranferir()
{
    Console.WriteLine($"== TRANSFERENCIA ==");
    Console.Write($"Conta de origem");
    int idOrigem = BuscarCliente();

    if (idOrigem == -1) return;


    Console.Write($"Conta de destino: ");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;

Console.Write($"Valor a ser transferido: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldo[idDestino] >= valor && valor > 0)
    {
        saldo[idOrigem] -= valor;
        saldo[idDestino] += valor;
        Console.WriteLine($"Transferencia concluida");
        
    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");
        
    }

}


int BuscarCliente()
{
    //listar cliente
    ListarClientes();//mostra a lista de clientes
    //pedir pro usuario escolher o cliente
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
        {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
        
    }
    
    //retornar ou devolver o id do cliente
    return idCliente;//vai ser torcado pelo id do cliente buscado


}