using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Contapoupanca : Conta
    {

        public float CalcularRendimento()
        {
            saldo = saldo + (2 / 100);
            return saldo;
        }

    }
}