using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double>notas=new List<double>(5);
        double soma = 0;
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite a " + (i + 1) + " nota" );

             double nota = Convert.ToDouble(Console.ReadLine());
            

            notas.Add(nota);
            soma += nota;
        
        }

        double maior = notas[0];
        double menor = notas[0];
    
     foreach (double nota in notas) 
    {
            if (nota > maior)
                maior = nota;

            if (nota < menor)
                menor = nota;
    }
     double media = soma / notas.Count;

        Console.WriteLine("\nNotas cadastradas:");
        foreach (double nota in notas)
        {
            Console.WriteLine(notas);
        }

        Console.WriteLine("\nMaior nota: " + maior);
        Console.WriteLine("Menor nota: " + menor);
        Console.WriteLine("Média: " + media);
    }
}

