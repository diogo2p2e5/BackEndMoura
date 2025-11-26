
using System.Diagnostics.Contracts;
using System.Net.Mail;

namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual = 0;

        public string ObterMarca()
        {

            return Marca;
        }
        public string ObterModelo()
        {
            return Modelo;
        }
        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }

        public void DefinirMarca(string valor)
        {

            valor = "volkswagen";

            Marca = valor;

        }

        public void DefinirModelo(string valor)
        {

            valor = "Fuscão";

            Modelo = valor;
        }

        public void Acelerar(int valor)
        {
            VelocidadeAtual += valor;

        }
        public void Frear(int valor)
        {
            VelocidadeAtual -= valor;
        }
    }
}

