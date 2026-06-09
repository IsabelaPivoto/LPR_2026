string[] cidades = { "Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};

int[,] matriz ={ {0, 524, 521, 882}, {524, 0, 434, 586}, {521, 434, 0, 429}, {882, 586, 429, 0} };

while (true )
{
    Console.WriteLine("Diga a sua cidade de origem:");

    for( int i = 0; i < cidades.Length; i++)
    {
        Console.WriteLine($"{i} - {cidades[i]}");
    }
    int origem = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Diga onde vc quer ir :");
    int destino = int.Parse(Console.ReadLine() ?? "0");

    if (origem == destino)
    {
        Console.WriteLine("Origem e destino iguais!");
        break;
    }

    Console.WriteLine($"Distância entre {cidades[origem]} e {cidades[destino]}:" + $"{matriz[origem, destino]} km");

    Console.WriteLine();
}