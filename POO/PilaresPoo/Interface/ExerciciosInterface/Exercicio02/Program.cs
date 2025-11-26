using System.Drawing;
using Exercicio02;

List<IImprimivel> Documentos = new List<IImprimivel>();


//Lista de dados da fatura
Console.WriteLine($"FATURAS:");
foreach (var Fat in Documentos)
{
    if (Fat is Fatura)
    {
        Fat.imprimir();
    }
}

Console.WriteLine($"CONTRATOS:");
foreach (var Cont in Documentos)
{
    if (Cont is Contrato)
    {
        Cont.imprimir();
    }
}

Console.WriteLine($"RELATORIOS:");
foreach (var Rel in Documentos)
{
    if (Rel is Relatorio)
    {
        Rel.imprimir();
    }
}
int opcao;

do
{
    Console.Clear();
    Console.Write($@"Menu de Opções
    1) Cadastrar Fatura
    2) Cadastrar Relátorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair
    Escolha a opção: 
    ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            CadastrarRelatorio();
            break;
        case 3:
            CadastrarContrato();
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            ListarRelatorio();
            break;
        case 6:
            ListarContrato();
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção inválida");

            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();
} while (opcao != 0);




//--------FUNÇÔES--------
void CadastrarFatura()
{
    Console.Write($"Digite o nome do Cliente Devedor: ");
    string dev = Console.ReadLine();

    Console.Write($"Digite o nome da empresa: ");
    string empresa = Console.ReadLine();

    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());

    Console.Write($"Dias de atraso da fatura: ");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Fatura Cadastrada com sucesso!");


    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    Documentos.Add(fat);

}
void CadastrarRelatorio()
{
    Console.Write($"DIgite o Nome do responsavel pelo relátorio: ");
    string responsavel = Console.ReadLine();

    Console.WriteLine($"Digite o Relátorio: ");
    string relatorio = Console.ReadLine();

    Relatorio rela = new Relatorio("nome", "texto");

    Relatorio Rel = new Relatorio(responsavel, relatorio);
    Documentos.Add(Rel);



}
void CadastrarContrato()
{
    Console.Write($"Digite o Nome do contratante: ");
    string nome = Console.ReadLine();

    Console.Write($"Digite as Clausulas do contrato:");
    string clausulas = Console.ReadLine();

    Contrato contrato = new Contrato("nome", "texto");


    Console.WriteLine($"Contrato cadastrado com sucesso!");

    Contrato Cont = new Contrato(nome, clausulas);
    Documentos.Add(Cont);



}
void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.imprimir();
        }
    }


}
void ListarRelatorio()
{
    Console.WriteLine($"Listando Relátorio");
    foreach (var item in Documentos)
    {
        if (item is Relatorio)
        {
            item.imprimir();
        }
    }


}
void ListarContrato()
{
    Console.WriteLine($"Listando Contratos");
    foreach (var item in Documentos)
    {
        if (item is Contrato)
        {
            item.imprimir();
        }


    }

}


































//criar uma lista para faturas, relatorios e contratos
// List<Fatura> ListaFaturas = new List<Fatura>();
// List<Relatorio> ListaRelatorios = new List<Relatorio>();
// List<Contrato> ListaContrato = new List<Contrato>();

//cria um  objeto de cada classe e adiciona a listas
// Fatura fatdiogo = new Fatura();
// ListaFaturas.Add(fatdiogo);

// Fatura fatjunior = new Fatura();
// ListaFaturas.Add(fatjunior);

// Relatorio reldiogo = new Relatorio();
// ListaRelatorios.Add(reldiogo);

// Contrato condiogo = new Contrato();
// ListaContrato.Add(condiogo);


