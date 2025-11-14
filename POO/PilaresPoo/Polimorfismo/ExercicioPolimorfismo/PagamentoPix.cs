using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo
{
    public class PagamentoPix : Pagamento
    {

        private float desconto = 5;

        public float valorCompra;

        public override float CalcularTotal()
        {
            float valorDesconto = valorCompra / 100 * desconto;
            return valorCompra = valorCompra - valorDesconto;
        }
    }
}