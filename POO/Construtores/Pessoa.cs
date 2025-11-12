
namespace Construtores
{
    public class Pessoa
    {
        //propriedades
        public string Nome;

        public int idade;

        //construtor


        public Pessoa()
        {
            Console.WriteLine($"Objeto Criado");

        }

        public Pessoa(string n, int i, string xpto)
        {
            idade = i;
            Nome = n;
            Console.WriteLine($"seu texto é {xpto}");
            
        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            idade = i;
        }

        public Pessoa(string n)
        {
            Nome = n;
        }


        //metodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {idade}");

        }
    }
}