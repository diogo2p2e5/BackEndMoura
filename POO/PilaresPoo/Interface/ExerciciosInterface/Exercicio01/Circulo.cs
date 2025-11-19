using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public double AreaTotal;

        public float Raio = 27;

        

        public Circulo(float R)
        {
            Raio = R;
        }


        public void CalcularArea()
        {

            AreaTotal =(float)Math.PI * Math.Pow (Raio , 2);

            Console.WriteLine($"A area total do seu Circulo é: {AreaTotal:F2}");


        }
    }
}