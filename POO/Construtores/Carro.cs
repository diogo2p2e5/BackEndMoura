

using System.Text;

namespace Construtores
{
    public class Carro
    {

        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string m, string mo, int a)
        {
            Marca = m;
            Modelo = mo;
            Ano = a;
        }



        public void DadosCarro()
        {
            Console.WriteLine($"seu carro é um {Marca} {Modelo} ano {Ano}");

        }





    }
}