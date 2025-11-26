using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
  public class Relatorio : IImprimivel
  {
    public string NomeResponsavel;

    public string TextoRelatorio;

    public Relatorio(string NR, string TR)
    {
      NomeResponsavel = NR;
      TextoRelatorio = TR;

    }



    public void imprimir()
    {
      Console.WriteLine($"Imprimindo o relatorio....");
      Console.WriteLine($@"
Nome: {NomeResponsavel}
{TextoRelatorio}
      ");
      

    }
  }
}