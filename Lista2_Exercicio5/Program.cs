//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze.
//  Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.
float qtdmacas = 0;

Console.WriteLine($"Quantas maçãs você quer comprar");
qtdmacas = float.Parse(Console.ReadLine());

if(qtdmacas < 12)
{
    Console.WriteLine($"obrigado por comprar! sua compra ficou {qtdmacas * 0.30}");
       
}else if(qtdmacas >= 12)
{
     Console.WriteLine($"obrigado por comprar! sua compra ficou R${qtdmacas * 0.25}");
}
