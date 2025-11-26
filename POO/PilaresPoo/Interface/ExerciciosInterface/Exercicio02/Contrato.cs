using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
  public class Contrato : IImprimivel
  {
    public string Nome;

    public string TextoClausulas;

    public Contrato(string N, string TC)
    {
      Nome = N;

      TextoClausulas = TC;


    }



    public void imprimir()
    {
      Console.WriteLine($"Imprimindo o contrato....");
      Console.WriteLine();
      Console.WriteLine($@"
Nome: {Nome}
{TextoClausulas}  
 ");
      


    }
  }
}