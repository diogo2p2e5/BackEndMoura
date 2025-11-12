
using System.Data.Common;

namespace ClassesEObjetos
{
    public class ContaBancaria
    {
        public string Titular;

        public float Saldo = 0;

        public void Depositar( float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"o valor do saldo deve ser maior que R$ 0");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Deposito efetuado com sucesso!!!");
                Console.WriteLine($"seu saldo atual: é R${Saldo}");
                
                
        }

        public void sacar(int valor)
        {
            if (valor <= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso!!!");
                Console.WriteLine($"seu saldo atual: é R${Saldo}");
            }
            
                Console.WriteLine($"Seu saldo atual é {Saldo}");
                Console.WriteLine($"Não possivel sacar esse valor, verifique o saldo ");
                return;
            
        }

    }
}