using System;
    struct filme
{
    public string titulo;
     public string diretor;
    public int AnoLancamento;
     public int DuracaoMinutos;
}

 class Program
{
    static void Main()
    {
         filme[] filme = new filme[3];
         for(int i=0; i < filme.Length; i++)
        {
            Console.WriteLine($"\nCadastro do Filme {i+1}:");

            Console.Write("Título: ");
            filme[i].titulo = Console.ReadLine();

            Console.Write("Diretor: ");
            filme[i].diretor = Console.ReadLine();

            Console.Write("Ano de lançamento: ");
            filme[i].AnoLancamento = int.Parse(Console.ReadLine() !);

            Console.Write("Duração em minutos: ");
            filme[i].DuracaoMinutos = int.Parse(Console.ReadLine() !);
        }
        Console.WriteLine("  Filmes Cadastrados  ");
        for(int i =0; i< filme.Length; i++)
        {
            Console.WriteLine($"\nFilme {i+1}");
            Console.WriteLine($"Título: {filme[i].titulo}");
            Console.WriteLine($"Diretor: {filme[i].diretor}");
            Console.WriteLine($"Ano de Lançamento: {filme[i].AnoLancamento}");
            Console.WriteLine($"Duração em minutos: {filme[i].DuracaoMinutos}");
        }

        filme maisAntigo = filme[0];

        for (int i = 1; i < filme.Length; i++)
        {
            if (filme[i].AnoLancamento < maisAntigo.AnoLancamento)
            {
                maisAntigo = filme[i];
            }
        }

        Console.WriteLine("Filme mais antigo");
        Console.WriteLine($"Título: {maisAntigo.titulo}");
        Console.WriteLine($"Diretor: {maisAntigo.diretor}");
        Console.WriteLine($"Ano de lançamento: {maisAntigo.AnoLancamento}");
    }
}
