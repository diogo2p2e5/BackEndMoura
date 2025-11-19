using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {

        public int NivelVolume = 0;

        public int VolumeMaximo = 100;





        public void AumentarVolume()
        {
            if(NivelVolume >= VolumeMaximo)
            {
                Console.WriteLine($"O volume já atingiu o nivel maximo {NivelVolume}");
                return;
                
            }
          NivelVolume ++;
          Console.WriteLine($"Volume: {NivelVolume}");
          
    
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando TV....");
        }

        public void DiminuirVolume()
        {
            if(NivelVolume == 0)
            {
                Console.WriteLine($"O volume atingiu seu nivel minimo {NivelVolume}");
                return;
                
            }
            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");
            
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando TV....");

        }
    }
}