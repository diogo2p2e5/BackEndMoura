



using System;

namespace ExemploAbstracao
{
    // Classe abstrata: modelo para diferentes formas de pagamento
    public abstract class Pagamento
    {
        public double Valor { get; set; }//set artribui o valor //get exibi o valor 

        // Método abstrato: deve ser implementado pelas subclasses
        public abstract void ProcessarPagamento();
    }








    //Classe concreta 1: Pagamento com Cartão
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R${Valor} no cartão {NumeroCartao}");
        }
    }

    //Classe concreta 2: Pagamento via PIX
    public class PagamentoPIX : Pagamento
    {
        public string ChavePIX { get; set; }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R${Valor} via PIX (Chave: {ChavePIX})");
        }
    }

   
   



    //Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            // Criando diferentes tipos de pagamento
            Pagamento pagamentoCartao = new PagamentoCartao()
            {
                Valor = 150.0,
                NumeroCartao = "1234-5678-9012-3456"
            };

            Pagamento pagamentoPIX = new PagamentoPIX()
            {
                Valor = 200.0,
                ChavePIX = "email@exemplo.com"
            };

            

            // Chamando o mesmo método abstrato — mas com comportamentos diferentes
            pagamentoCartao.ProcessarPagamento();
            pagamentoPIX.ProcessarPagamento();

            Console.WriteLine("Pagamentos processados com sucesso!");
        }
    }
}


