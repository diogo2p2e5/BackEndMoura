using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public class Cachorro : Animal
    {
        public override void Fazersom()
        {
            Console.WriteLine($"AU AU AUUUUUU");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Tic tic tic");
            
        }
    }
}