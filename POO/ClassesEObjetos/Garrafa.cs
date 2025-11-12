using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Garrafa
    {
         public string marca;

        public int capacidade;

        public string material;

        public void encher()
        {
            Console.WriteLine($"Enchendo a garrafa");

        }

        public void esvaziar()
        {
            Console.WriteLine($"Esvaziando a garrafa");

        }
    }
}