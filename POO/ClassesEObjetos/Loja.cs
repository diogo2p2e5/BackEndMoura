
namespace ClassesEObjetos
{
    public class Loja
    {
        public string Nome;

        public double Preco = 0;


        public void AplicarDesconto(double Percentual)
        {
            if (Percentual > 0 && Percentual <= 50)
            {
                double ValorDesconto = Preco * (Percentual / 100);
                Preco -= ValorDesconto;
                Console.WriteLine($"Desconto de {Percentual}% foi aplicado e o novo preço é {Preco}");
            }
            else
            {
                Console.WriteLine($"O desconto aplicado é inválido");
                
            }


        }






    }
}