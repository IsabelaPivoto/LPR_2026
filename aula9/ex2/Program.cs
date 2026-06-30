using System;
using System.Collections.Generic;

class Program
{static void Main()
    {
        Console.Write("Quantos nomes deseja cadastrar? ");
        int x = Convert.ToInt32(Console.ReadLine());

        List<string> nomes = new List<string>();

        for (int i = 0; i < x; i++)
        {
            Console.Write("Digite um nome: ");
            nomes.Add(Console.ReadLine());
        }

        bool[] usado = new bool[x];
        int exibidos = 0;

        while (exibidos < x)
        {
            List<int>posicoes = new List<int> ();

            for(int tam = 1; tam <= 50; tam++)
            {
                 bool encontrou = false;
           
            for (int i = 0; i < nomes.Count && !encontrou; i ++ )
            {
                 if (!usado[i] && nomes[i].Length == tam)
                    {
                        Console.Write(nomes[i] + " ");
                        posicoes.Add(i);
                        encontrou = true;
                    }
                }
            }
        

             Console.WriteLine();

            foreach (int i in posicoes)
            {
                usado[i] = true;
                exibidos++;
            }
        }
}
}

