using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;

        public int idade;
        public override void Fazersom()
        {
          Console.WriteLine($"AAAAAAAAAAAAHHHHHHHHHHH");
          
        }

        public override void Mover()
        {
         Console.WriteLine($"TOC TOC TOC TOC");
         ;
        }

        public void Dormir()
        {
            Console.WriteLine($"ZZZZZZZZZZZZZZZZZ...");
            
        }
    }
}