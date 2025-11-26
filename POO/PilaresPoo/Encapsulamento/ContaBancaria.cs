using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;


        public float GetSaldo()
        {
            return Saldo;
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)
            {

                Console.WriteLine($"Valor inválido");
            }
            else
            {
                
            Saldo += valor;

            }

        }

        public void Sacar(float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
            Saldo -= valor;
            }
            else
            {  
                Console.WriteLine($"Valor inválido");   
            }
        }
    }
}