 using System;

struct Heroi
{
    public string nome;
    public string poder;
    public int pontuacao;
}

struct Equipe
{
    public Heroi[] herois;
    public int pontuacaoTotal;
}

class Program
{
    static void cadastrarHeroi(Heroi[] herois)
    {
        for (int i = 0; i < herois.Length; i++)
        {
            Console.WriteLine($"\nCadastro do Herói {i + 1}");

            Console.Write("Nome: ");
            herois[i].nome = Console.ReadLine()!;

            Console.Write("Poder: ");
            herois[i].poder = Console.ReadLine()!;

            Console.Write("Pontuação: ");
            herois[i].pontuacao = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("\nHeróis cadastrados com sucesso!");
    }

    static void selecionarEquipe(Heroi[] herois, Equipe equipe)
    {
        Console.WriteLine("\n=== HERÓIS DISPONÍVEIS ===");

        for (int i = 0; i < herois.Length; i++)
        {
            Console.WriteLine($"{i} - {herois[i].nome} ({herois[i].poder})");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nEscolha o herói {i + 1}: ");
            int indice = int.Parse(Console.ReadLine()!);

            equipe.herois[i] = herois[indice];
        }

        equipe.pontuacaoTotal = calcularPontuacaoTotal(equipe);
    }

    static int calcularPontuacaoTotal(Equipe equipe)
    {
        int total = 0;

        for (int i = 0; i < equipe.herois.Length; i++)
        {
            total += equipe.herois[i].pontuacao;
        }

        return total;
    }

    static void exibirEquipe(Equipe equipe)
    {
        Console.WriteLine("\n=== EQUIPE SELECIONADA ===");

        for (int i = 0; i < equipe.herois.Length; i++)
        {
            Console.WriteLine(
                $"{equipe.herois[i].nome} - Poder: {equipe.herois[i].poder} - Pontuação: {equipe.herois[i].pontuacao}"
            );
        }

        Console.WriteLine($"\nPontuação Total: {equipe.pontuacaoTotal}");
    }

    static void menuPrincipal()
    {
        Heroi[] herois = new Heroi[5];

        Equipe equipe = new Equipe();
        equipe.herois = new Heroi[3];

        int opcao;

        do
        {
            Console.WriteLine("\n MENU ");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi(herois);
                    break;

                case 2:
                    selecionarEquipe(herois, equipe);
                    break;

                case 3:
                    exibirEquipe(equipe);
                    break;

                case 4:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }

    static void Main()
    {
        menuPrincipal();
    }
}