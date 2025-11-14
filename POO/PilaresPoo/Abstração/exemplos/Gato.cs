using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public class Gato : Animal
    {
        public override void Fazersom()
        {
            Console.WriteLine($"MIAU...MIAUUUUUU...MIAU");
            
        }

        public override void Mover()
        {
           Console.WriteLine($"toc...toc...toc");
           
        }
    }
}