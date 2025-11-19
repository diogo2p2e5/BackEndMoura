using System.Net.NetworkInformation;

namespace Exemplos
{
    public class Carro : IMotor
    {

        public string cor;
        public string marca;
        public string modelo;
        public int ano;

        public Carro(string c, string m, string md, int a)
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
            Console.WriteLine($"Carro acelerando... Vrum Vrum");

        }

        public void Freiar()
        {
            Console.WriteLine($"Carro freiando... irrrrrrrh");

        }
    }
}