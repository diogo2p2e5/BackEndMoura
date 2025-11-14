using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Conta
    {
        public float valor;

        public float saldo = 0;

        public void depositar()
        {
            saldo += valor;
        }
        
        public void sacar()
        {
            saldo -= valor;
        }
    }
}