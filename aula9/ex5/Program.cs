using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Quantos nomes aleatórios deseja gerar? ");
        int x = int.Parse(Console.ReadLine()!);

     
        string[] bancoNomes =
        {
            "Ana", "Pedro", "Joao", "Maria", "Lucas",
            "Bia", "Jose", "Carlos", "Paula", "Marcos",
            "Julia", "Rafaela", "Gabriel", "Mateus", "Bruno",
            "Fernanda", "Amanda", "Luiz", "Beatriz", "Cauã"
        };

        Random rnd = new Random();

        Dictionary<int, List<string>> nomes = new Dictionary<int, List<string>>();

        for (int i = 0; i < x; i++)
        {
            string nome = bancoNomes[rnd.Next(bancoNomes.Length)];

            int tamanho = nome.Length;

            if (!nomes.ContainsKey(tamanho))
            {
                nomes[tamanho] = new List<string>();
            }

            nomes[tamanho].Add(nome);
        }

        List<int> tamanhos = nomes.Keys.OrderBy(t => t).ToList();

        Console.WriteLine("\nSaída:");

        bool existeNome = true;
        int linha = 0;

        while (existeNome)
        {
            existeNome = false;

            foreach (int tamanho in tamanhos)
            {
                if (linha < nomes[tamanho].Count)
                {
                    Console.Write(nomes[tamanho][linha] + "\t");
                    existeNome = true;
                }
            }

            if (existeNome)
                Console.WriteLine();

            linha++;
        }
    }
}