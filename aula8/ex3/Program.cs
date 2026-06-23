using System;
    struct livro
{
    public string titulo;
     public string autor;
    public int anoPublicado;
     public int numeroPaginas;
     public int preco;
}
class Program
{
    static void Main()
    {
         livro[] livro = new livro[3];

         int precoTotal = 0;
         int totalPaginas = 0;


         for(int i=0; i < livro.Length; i++)
        {
            Console.WriteLine($"\nCadastro do livro {i+1}:");

            Console.Write("título: ");
            livro[i].titulo = Console.ReadLine()!;

            Console.Write("autor: ");
            livro[i].autor = Console.ReadLine()!;

            Console.Write("Ano Publicado: ");
            livro[i].anoPublicado = int.Parse(Console.ReadLine()!);

            Console.Write("Número de páginas: ");
            livro[i].numeroPaginas = int.Parse(Console.ReadLine()!);

            Console.Write("Preço: ");
            livro[i].preco = int.Parse(Console.ReadLine()!);

             precoTotal += livro[i].preco;
            totalPaginas += livro[i].numeroPaginas;
        }

        double mediaPaginas = (double)totalPaginas / livro.Length;

        Console.WriteLine("   Resultado   ");
        Console.WriteLine($"Preço total dos livros: R$ {precoTotal}");
        Console.WriteLine($"Média de páginas dos livros: {mediaPaginas:F2}");
    }
}
