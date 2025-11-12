
namespace Construtores
{
    public class Produto
    {
        public string Nome;

        public double Preco;

        public int Estoque;

        public Produto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;

        }


        public void ExibirDados()
        {
            Console.WriteLine($"Nome do produto: {Nome} | Preço do {Nome}: R${Preco:F2} | Estoque do {Nome}: {Estoque}");

        }



    }
}