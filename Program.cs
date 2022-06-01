using System.Collections.Generic;
using Coleçoes_Genericas.Helper;
namespace Coleçoes_Genericas
{

  class Program
  {

    static void Main(string[] args)
    {

      //------------------(LINQ)-----------------------------------------------------------------------

      int[] arrayNumeros = new int[10] { 100, 1, 4, 8, 0, 15, 19, 19, 4, 100 };

      var minimo = arrayNumeros.Min();
      var maximo = arrayNumeros.Max();
      var medio = arrayNumeros.Average();
      var soma = arrayNumeros.Sum();
      var arrayUnico = arrayNumeros.Distinct().ToArray();

      System.Console.WriteLine($"Minimo :{minimo}");
      System.Console.WriteLine($"Maximo :{maximo}");
      System.Console.WriteLine($"Médio :{medio}");
      System.Console.WriteLine($"Soma :{soma}");
      System.Console.WriteLine($"Array Original:{string.Join(", ", arrayNumeros)}");
      System.Console.WriteLine($"Array Distinto:{string.Join(", ", arrayUnico)}");




      // var numerosParesQuery =
      //             from num in arrayNumeros
      //             where num % 2 ==0
      //             orderby num
      //             select num;


      //  //Segunda forma utilizando Métodos -------------------
      //  var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();           

      //  System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));

      //  System.Console.WriteLine("Numeros pares método " + string.Join(", ", numerosParesMetodo)); 



      //-----------------(DICIONÁRIOS)---------------------------------------------------------------------
      // Dictionary<string, string> estados = new Dictionary<string, string>();

      // estados.Add("SP", "São Paulo");
      // estados.Add("MG", "Minas Gerais");
      // estados.Add("BA", "Bahia");

      // foreach (KeyValuePair<string, string> item in estados)
      // {
      //   //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
      // }

      // string valorProcurado = "BA";
      // //var teste = estados["SC"];


      // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
      // {
      //   System.Console.WriteLine(estadoEncontrado);
      // }
      // else
      // {
      //   System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
      // }


      // System.Console.WriteLine($"Removendo valor: {valorProcurado}");
      // estados.Remove(valorProcurado);

      // foreach (KeyValuePair<string, string> item in estados)
      // {
      //   System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
      // }

      // System.Console.WriteLine("Valor original");
      // System.Console.WriteLine(estados[valorProcurado]);

      // estados[valorProcurado] = "BA - teste atualização";
      //  System.Console.WriteLine("Valor atualizado");
      // System.Console.WriteLine(estados[valorProcurado]); 


      //-----------------(FILAS E PILHAS)----------------------------------------------------------------
      // Stack<string> pilhaLivros = new Stack<string>();

      // pilhaLivros.Push(".NET");
      // pilhaLivros.Push("DDD");
      // pilhaLivros.Push("Código Limpo");

      // System.Console.WriteLine($"Livor para a leitura {pilhaLivros.Count()}");
      // while (pilhaLivros.Count > 0)
      // {
      //   System.Console.WriteLine($"Póximo livro pra leitura {pilhaLivros.Peek()}");
      //   System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");
      // }
      // System.Console.WriteLine($"Livor para a leitura {pilhaLivros.Count()}");


      // Queue<string> fila = new Queue<string>();
      // fila.Enqueue("Cassiano");
      // fila.Enqueue("Lucas");
      // fila.Enqueue("Maria");

      // System.Console.WriteLine($"Pessoas na fila {fila.Count}");
      // while (fila.Count >0)
      // {
      //   System.Console.WriteLine($"Vez de : {fila.Peek()}");
      //   System.Console.WriteLine($"{fila.Dequeue()} atendido");
      // }
      //  System.Console.WriteLine($"Pessoas na fila {fila.Count}");



      //---------(COLEÇÕES GENÉRICAS)--------------------------------------------
      // OperacoesLista oplista = new OperacoesLista();

      // List<string>estados = new List<string>{"SP", "MG", "BA"};
      // string [] estadoArray = new string[2]{"SC", "MT"};



      // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

      // oplista.ImprimirListaString(estados);



      // // System.Console.WriteLine("Removendo o elemnto da lista ");
      // // estados.Remove("MG");

      // //estados.AddRange(estadoArray); // Adiciona Uma lista e um Array de String

      // estados.Insert(1,"RJ");  //Adicionando elemento por Indice 

      // oplista.ImprimirListaString(estados);








    }

  }

}





