using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    public static class CalculosMatematicos
    {
        public static double PI = 3.14;

        public static float somar(float x, float y)
        {
            
            return x + y;
            
        }

        public static float multiplicacao(float x, float y)
        {
            if(x == 0 && y == 0)
            {
                Console.WriteLine($"Não é possivél realizar a operação");


            }
            return x * y;
        }

        public static float subtracao(float x, float y)
        {
            if(x > y)
            {
                return x - y;

            }
            else
            {
            return y - x;
                
            }

        }

          public static float divisao(float x, float y)
        {
         if(y == 0){
                Console.WriteLine($"Não é possivél realizar a operação");
            }
        
            return x / y;
        

        }


        
    }
}