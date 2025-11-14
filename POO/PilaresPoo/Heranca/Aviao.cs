using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public string destino;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Destino: {destino}");

        }

        public void voar()
        {
            Console.WriteLine($"SHUUUUUUUU");

        }

        public void acelera()
        {
            Console.WriteLine($"VUUUUUUUUUU");
            
        }
    }
}