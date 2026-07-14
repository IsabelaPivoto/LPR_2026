using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Quantas pessoas deseja cadastrar? ");
        int x = int.Parse(Console.ReadLine()!);

        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        for (int i = 0; i < x; i++)
        {
            Console.Write("\nNome: ");
            string nome = Console.ReadLine()!;

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine()!);

            pessoas[nome] = idade;
        }

        double media = pessoas.Values.Average();

        Console.WriteLine($"\nMédia das idades: {media:F2}");

        Console.WriteLine("\nPessoas com idade acima da média:");

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > media)
            {
                Console.WriteLine(pessoa.Key);
            }
        }

        int maiorIdade = pessoas.Values.Max();
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == maiorIdade)
            {
                Console.WriteLine($"\nPessoa mais velha: {pessoa.Key}");
                break;
            }
        }

        int menorIdade = pessoas.Values.Min();
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == menorIdade)
            {
                Console.WriteLine($"Pessoa mais nova: {pessoa.Key}");
                break;
            }
        }

        Console.Write("\nDigite a idade que deseja remover: ");
        int y = int.Parse(Console.ReadLine()!);

        List<string> remover = new List<string>();

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == y)
            {
                remover.Add(pessoa.Key);
            }
        }

        foreach (string nome in remover)
        {
            pessoas.Remove(nome);
        }

        Console.WriteLine("\nDicionário atualizado:");

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
        }
    }
}