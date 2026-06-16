using System;
    struct produto
{
    public string nome;
     public int codigo;
    public double preco;
     public int quantidade;
}
class Program
{
    static void Main()
    {
         produto[] produto = new produto[3];
         double valorTotal = 0;

         for(int i=0; i < produto.Length; i++)
        {
            Console.WriteLine($"\nCadastro do Produto {i+1}:");

            Console.Write("Nome: ");
            produto[i].nome = Console.ReadLine()!;

            Console.Write("Código: ");
            produto[i].codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Preço: ");
            produto[i].preco = double.Parse(Console.ReadLine()!);

            Console.Write("Quantidade: ");
            produto[i].quantidade = int.Parse(Console.ReadLine()!);

             valorTotal += produto[i].preco * produto[i].quantidade;
        }

        Console.WriteLine("  Produtos Cadastrados: ");

        for(int i = 0; i < produto.Length; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}");
            Console.WriteLine($"Nome: {produto[i].nome}");
            Console.WriteLine($"Código: {produto[i].codigo}");
            Console.WriteLine($"Preço: R$ {produto[i].preco:F2}");
            Console.WriteLine($"Quantidade: {produto[i].quantidade}");
        }

        Console.WriteLine($"\nValor total em estoque: R$ {valorTotal:F2}");
    }
}