Console.WriteLine("Digite 10 números inteiros:");

int [] numeros = new int[10];
int contador = 0;

for ( int i = 0; i < 10; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite um número que você gostaria de pesquisar no vetor:");

int numero = int.Parse(Console.ReadLine());

for ( int i = 0; i < 10; i++)
{
    if(numeros[i] == numero)
    {
        Console.WriteLine($"Encontrado na posição: {i}");
        contador++;
    }
}
Console.WriteLine($"Quantidade de ocorrências: {contador}");
