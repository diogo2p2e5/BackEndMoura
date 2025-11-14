using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double saldo = 0;
        private double TaxaSaque = 5;


        public ContaCorrente(double saldoInicial)
        {
            saldo = saldoInicial;

        }


        public override void Despositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor de depósito inválido");
                return;
            }
            saldo += valor;
        }

        public override void Sacar(double valor)
        {
            double TotalComTaxa = (valor / 100 * TaxaSaque) + valor;

            if (valor <= 0 || saldo < TotalComTaxa)
            {
                Console.WriteLine($"O valor do saque deve ser positivo e conter saldo disponivel");
                return;
            }
            saldo -= TotalComTaxa;

        }
    }
}