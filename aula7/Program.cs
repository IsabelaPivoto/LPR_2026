Console.WriteLine("10 Números inteiros:");

int [] numeros = new int[10];
int [] pares = new int[10];
int [] impares = new int[10];

int qtdpares = 0;
int qtdimpares = 0;

for(int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());


 if (numeros[i] % 2 == 0)
    {
        pares[qtdpares] = numeros[i];
        qtdpares++;
    }
    else
    {
        impares[qtdimpares] = numeros[i];
        qtdimpares++;
    }

}

Console.Write("PAR: ");

for (int i = 0; i < qtdpares; i++)
{
    Console.Write(pares[i] + " ");
}

Console.WriteLine();

Console.Write("ÍMPAR: ");

for (int i = 0; i < qtdimpares; i++)
{
    Console.Write(impares[i] + " ");
}