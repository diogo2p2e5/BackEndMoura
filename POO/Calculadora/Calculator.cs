using System.Diagnostics.Contracts;

namespace Calculadora
{
    public class Calculator
    {
        //atributos
        //numero1, numero2, resultado
        public double Numero1;

        public double Numero2;

        public double Resultado;


        public double Somar()
        {
            Resultado = Numero1 + Numero2;
            
            return Resultado;
        }
        public double Subtrair()
        {
            Resultado = Numero1 - Numero2;

            return Resultado;
        }
        public double Dividir()
        {
            if (Numero2 == 0 && Numero1 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero");
                return -1;

            }

            Resultado = Numero1 / Numero2;
            
            return Resultado;
        }
        public double Multiplicacao()
        {
            Resultado = Numero1 * Numero2;
    
            return Resultado;
        }
    }
}