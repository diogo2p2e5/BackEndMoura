int opcao = -1;

do
{

Console.Clear();
Console.WriteLine($"-------------------------------------------------------------");
Console.WriteLine($"                          Bem Vindo                          ");
Console.WriteLine($"                              ao                             ");
Console.WriteLine($"                       robertinho sushi                      ");
Console.WriteLine($"-------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Escolha uma opção do menu abaixo");
Console.WriteLine();
Console.WriteLine($" 1)     Sushi .............................. R$29,90");
Console.WriteLine($" 2)     Niguiri ............................ R$17,90");
Console.WriteLine($" 3)     Temaki ............................. R$35,80");
Console.WriteLine($" 4)     Yakisoba ........................... R$45,50");
Console.WriteLine($" 5)     Hossomaki .......................... R$23,80");
Console.WriteLine($" 0)     Sair");
Console.Write($"Opção: ");
 opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 0:
            Sair();
        break;
        case 1:
            Sushi();
        break;
    case 2:
            Niguiri();
        break;
        case 3:
            Temaki();
        break;
    case 4:
            Yakisoba();
        break;
    case 5:
            Hossomaki();
        break;

    default:
        Console.WriteLine($"Opção inválida");
        break;
}
        Console.WriteLine($"Digite <Enter> para continuar ...");
        Console.ReadLine();
} while (opcao != 0);

void  Sushi()
{
            Console.WriteLine($"Boa escolha, vmaos preparar o seu Sushi com carinho");
}
void  Niguiri()
{
            Console.WriteLine($"Boa escolha, vmaos preparar o seu Niguiri com carinho");
}
void  Temaki()
{
            Console.WriteLine($"Boa escolha, vmaos preparar o seu Temaki com carinho");

}
void  Yakisoba()
{
            Console.WriteLine($"Boa escolha, vmaos preparar o seu Yakisoba com carinho");
}
void  Hossomaki()
{
             Console.WriteLine($"Boa escolha, vmaos preparar o seu Hossomaki com carinho");
}
void  Sair()
{
           Console.WriteLine($"Saindo ...");
}



 