using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float AreaTotal;
        public float Altura;
        public float Largura;

        public Retangulo(float A, float L)
        {
            Altura = A;
            Largura = L;

        }


        public void CalcularArea()
        {

            AreaTotal = Altura * Largura;

            Console.WriteLine($"A area do seu retângulo é: {AreaTotal}");

        }
    }
}