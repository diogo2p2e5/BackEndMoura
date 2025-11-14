using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Gerente : Funcionario
    {
        public string demitiralguem;

        public double GerenteBonus = 500;

        public void CalcularSalario()
        {

            salariobase += GerenteBonus;
        }


    }
}