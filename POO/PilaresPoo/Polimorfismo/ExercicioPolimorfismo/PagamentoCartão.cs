using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo
{
    public class PagamentoCartão : Pagamento
    {
        private float acresimo = 5.38f;

        public float valorCompra;

        public float ValorTotal;
        public override float CalcularTotal()
        {
            float valorAcrescimo = valorCompra / 100 * acresimo;

           return valorCompra = valorCompra + valorAcrescimo;
        }
    }
}