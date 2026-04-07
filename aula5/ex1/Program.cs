using System;
class Program
{
    static void Main()
    {
       Console.WriteLine("Digite números e direi a média deles:");
        int numeros;
        int soma = 0;
        int pares = 0;

         Console.Write("Quantos números vai digitar? ");
        numeros = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeros; i++)
        {
            Console.Write("Digite um número: ");
            numeros = int.Parse(Console.ReadLine());

            if (numeros % 2 == 0)
            {
                soma = soma + numeros;
                pares = pares + 1;
            }
        }

        if (pares == 0)
        {
            Console.WriteLine("Não tem números pares.");
        }
        else
        {
            Console.WriteLine("Média = " + (soma / pares));
        }
    }
}

  



