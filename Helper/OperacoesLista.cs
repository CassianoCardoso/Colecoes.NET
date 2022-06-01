using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coleçoes_Genericas.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
             System.Console.WriteLine("Usando o FOR ");

      for (int i = 0; i < lista.Count; i++)
      {
        System.Console.WriteLine($"indice :{i}, Valor:{lista[i]}");
      }
        }
    }
}