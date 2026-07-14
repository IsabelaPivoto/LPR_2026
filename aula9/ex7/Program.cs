using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> cidades = new Dictionary<string, int>();

        Console.Write("Quantas cidades deseja cadastrar? ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.Write("\nNome da cidade: ");
            string nome = Console.ReadLine();

            Console.Write("População: ");
            int populacao = int.Parse(Console.ReadLine());

            cidades[nome] = populacao;
        }

        double media = cidades.Values.Average();

        Console.WriteLine($"\nMédia das populações: {media}");

        Console.WriteLine("\nCidades com população acima da média:");
        foreach (var cidade in cidades)
        {
            if (cidade.Value > media)
            {
                Console.WriteLine($"{cidade.Key} - {cidade.Value} habitantes");
            }
        }

        int maiorPop = cidades.Values.Max();
        string cidadeMaior = "";

        int menorPop = cidades.Values.Min();
        string cidadeMenor = "";

        foreach (var cidade in cidades)
        {
            if (cidade.Value == maiorPop)
                cidadeMaior = cidade.Key;

            if (cidade.Value == menorPop)
                cidadeMenor = cidade.Key;
        }

        Console.WriteLine($"\nCidade mais populosa: {cidadeMaior}");
        Console.WriteLine($"Cidade menos populosa: {cidadeMenor}");

        Console.Write("\nDigite a população que deseja remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (var cidade in cidades)
        {
            if (cidade.Value == y)
            {
                remover.Add(cidade.Key);
            }
        }

        foreach (string nome in remover)
        {
            cidades.Remove(nome);
        }

        Console.WriteLine("\nDicionário atualizado:");
        foreach (var cidade in cidades)
        {
            Console.WriteLine($"{cidade.Key} - {cidade.Value} habitantes");
        }
    }
}