using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numeros = new List<int>();

        
        for (int i = 0; i < 100; i++)
        {
            numeros.Add(random.Next(1, 101));
        }

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            for (int j = 0; j < numeros.Count - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int aux = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = aux;
                }
            }
        }

        Console.WriteLine("Lista ordenada:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();

        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            if (numeros[i] % 2 == 0)
            {
                numeros.RemoveAt(i);
            }
        }

        Console.WriteLine("\nLista sem os números pares:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();

        Console.WriteLine("\nNúmeros repetidos:");

        bool encontrou = false;

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            if (numeros[i] == numeros[i + 1])
            {
                Console.Write(numeros[i] + " ");

                while (i < numeros.Count - 1 && numeros[i] == numeros[i + 1])
                {
                    i++;
                }

                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Não existem números repetidos.");
        }
    }
}

