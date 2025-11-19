using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor
    {

        public string cor;
        public string marca;
        public string modelo;
        public int ano;

        public Moto(string c, string m, string md, int a)
        {

            cor = c;
            marca = m;
            modelo = md;
            ano = a;

        }


        public void ExibirInfo()
        {
            Console.WriteLine($@"informaçóes do Veiculo:
                                Marca: {marca}
                                Modelo: {modelo}
                                Ano: {ano}
                                Cor: {cor}
            ");
        }



        public void Acelerar()
        {
            Console.WriteLine($"Acelerando moto... vuvuvuvuuuuuum");

        }

        public void Freiar()
        {
            Console.WriteLine($"freiando carro... kiiiirrrrrrrr");

        }
    }
}