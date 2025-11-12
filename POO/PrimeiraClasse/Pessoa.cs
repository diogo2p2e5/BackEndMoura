
namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;

        public int Altura;

        public int Idade = 0;

        public string campeonatos;

        public void habilidade()
        {
            Console.WriteLine($"é o melhor piloto");

        }

        public void fala()
        {
            Console.WriteLine($"Nothing, just an inchident");

        }

//se não treinar vai envelhecer mais rapido
        public void envelhecer(int _id = 0)
        {
            if (_id > 0)
            {//adiciona a idade que foi recebida
                Idade += _id;
            }
            else
            {//adiciona 1 ano a idade
            Idade++;
            }
        }




    }
}