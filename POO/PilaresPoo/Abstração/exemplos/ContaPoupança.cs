using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public class ContaPoupança : ContaBancaria
    {
        public double saldo = 0;

        private double TaxaSaque = 3;

        public ContaPoupança(double saldoInicial)
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
            throw new NotImplementedException();
        }
    }
}