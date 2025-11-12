using Calculadora;
int opcao = -1;


Console.Clear();

Calculator calc = new Calculator();
double n1 = calc.Numero1;
double n2 = calc.Numero2;

do
{
    Console.WriteLine($"====================================================================");
    Console.WriteLine($"                             Bem Vindo                              ");
    Console.WriteLine($"                                 a                                  ");
    Console.WriteLine($"                            Calculadora                             ");
    Console.WriteLine($"====================================================================");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Escolha uma das operações");
    Console.WriteLine();
    Console.WriteLine($" 1) Soma");
    Console.WriteLine($" 2) Subtração");
    Console.WriteLine($" 3) Divisão");
    Console.WriteLine($" 4) Multiplicação");
    Console.WriteLine($" 0) Sair");

    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o primeiro numero");
    calc.Numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o Segundo numero");
    calc.Numero2 = int.Parse(Console.ReadLine());



    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");

            break;
        case 1:
           Console.WriteLine($"Resultado da sua soma {calc.Somar()}");
            break;
        case 2:
             Console.WriteLine($"Resultado da sua subtração {calc.Subtrair()}");
            break;
        case 3:
             Console.WriteLine($"Resultado da sua divisão {calc.Dividir()}");
            break;
        case 4:
             Console.WriteLine($"Resultado da sua multiplicação {calc.Multiplicacao()}");
            break;

        default:
            Console.WriteLine($"Opção inválida");

            break;
    }

    Console.WriteLine($"Pressione ENTER para Fazer outra Operação");
    Console.WriteLine();


} while (opcao != 0);


// calc.Numero1 = 50;
// calc.Numero2 = 35;

// Console.WriteLine($"== Calculadora==");
// Console.WriteLine($"Primeiro Numero: {calc.Numero1}");
// Console.WriteLine($"Segundo Numero: {calc.Numero2}");


// Console.WriteLine($"soma {calc.Somar()}");
// Console.WriteLine();

// Console.WriteLine($"subtração {calc.Subtrair()}");
// Console.WriteLine();

// Console.WriteLine($"divisão {calc.Dividir()}");
// Console.WriteLine();

// Console.WriteLine($"multiplicação {calc.Multiplicacao()}");
// Console.WriteLine();
