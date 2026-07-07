using System;
using System.Collections.Generic;
class Program
{
 static void Main()
    {
      Dictionary<string, string> jogos = new Dictionary<string, string>();

      for(int i=1; i<=5; i++)
        {
            Console.WriteLine("Digite o nome do jogo:");
            string nome = Console.ReadLine();

             Console.WriteLine("Digite o gênero do jogo:");
             string genero = Console.ReadLine();

              jogos[nome] = genero;
        }

        Console.WriteLine("\n Digite o nome que deseja pesquisar:");
        string pesquisa = Console.ReadLine();

        if (jogos.ContainsKey(pesquisa))
        {
             Console.WriteLine("Gênero: " + jogos[pesquisa]);
        }

        else
        {
            Console.WriteLine("Jogo não cadastrado.");
        }
    }
}