

namespace Construtores
{
    public class Aluno
    {

        public string Nome;

        public int Nota;

        public Aluno(string n, int no)
        {
            Nome = n;
            Nota = no;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do Aluno/a: {Nome}, e sua nota é {Nota}");
            
        }


    }
}