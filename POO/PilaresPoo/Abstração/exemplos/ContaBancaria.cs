using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public abstract class ContaBancaria
    {
            public abstract void Despositar(double valor);

            public abstract void Sacar(double valor);


    }
}