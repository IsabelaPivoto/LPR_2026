using System;

struct Chamado
{
    public int numero;
    public string solicitante;
    public string setor;
    public int prioridade;
    public string status;
    public string descricao;
}

class Program
{
    static int quantidade = 0;

    static void cadastrarChamado(Chamado[] chamados)
    {
        if (quantidade >= chamados.Length)
        {
            Console.WriteLine("Limite de chamados atingido!");
            return;
        }

        Console.WriteLine("\n  Cadastro de Chamado  ");

        Console.Write("Número: ");
        chamados[quantidade].numero = int.Parse(Console.ReadLine()!);

        Console.Write("Solicitante: ");
        chamados[quantidade].solicitante = Console.ReadLine()!;

        Console.Write("Setor: ");
        chamados[quantidade].setor = Console.ReadLine()!;

        Console.Write("Prioridade (1-Baixa, 2-Média, 3-Alta): ");
        chamados[quantidade].prioridade = int.Parse(Console.ReadLine()!);

        Console.Write("Descrição: ");
        chamados[quantidade].descricao = Console.ReadLine()!;

        chamados[quantidade].status = "Aberto";

        quantidade++;

        Console.WriteLine("Chamado cadastrado com sucesso!");
    }

    static void listarChamados(Chamado[] chamados)
    {
        Console.WriteLine("\n   LISTA DE CHAMADOS   ");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nNúmero: {chamados[i].numero}");
            Console.WriteLine($"Solicitante: {chamados[i].solicitante}");
            Console.WriteLine($"Setor: {chamados[i].setor}");
            Console.WriteLine($"Prioridade: {classificarPrioridade(chamados[i].prioridade)}");
            Console.WriteLine($"Status: {chamados[i].status}");
            Console.WriteLine($"Descrição: {chamados[i].descricao}");
        }
    }

    static void atualizarStatus(Chamado[] chamados)
    {
        Console.Write("\nDigite o número do chamado: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].numero == numero)
            {
                Console.WriteLine("1 - Em andamento");
                Console.WriteLine("2 - Resolvido");
                Console.WriteLine("3 - Cancelado");

                Console.Write("Escolha: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        chamados[i].status = "Em andamento";
                        break;
                    case 2:
                        chamados[i].status = "Resolvido";
                        break;
                    case 3:
                        chamados[i].status = "Cancelado";
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                return;
            }
        }

        Console.WriteLine("Chamado não encontrado!");
    }

    static string classificarPrioridade(int prioridade)
    {
        switch (prioridade)
        {
            case 1:
                return "Baixa";
            case 2:
                return "Média";
            case 3:
                return "Alta";
            default:
                return "Inválida";
        }
    }

    static void estatisticas(Chamado[] chamados)
    {
        int abertos = 0;
        int andamento = 0;
        int resolvidos = 0;
        int cancelados = 0;

        for (int i = 0; i < quantidade; i++)
        {
            switch (chamados[i].status)
            {
                case "Aberto":
                    abertos++;
                    break;

                case "Em andamento":
                    andamento++;
                    break;

                case "Resolvido":
                    resolvidos++;
                    break;

                case "Cancelado":
                    cancelados++;
                    break;
            }
        }

        Console.WriteLine("\n   ESTATÍSTICAS   ");
        Console.WriteLine($"Abertos: {abertos}");
        Console.WriteLine($"Em andamento: {andamento}");
        Console.WriteLine($"Resolvidos: {resolvidos}");
        Console.WriteLine($"Cancelados: {cancelados}");
    }

    static void Main()
    {
        Chamado[] chamados = new Chamado[10];
        int opcao;

        do
        {
            Console.WriteLine("\n    MENU    ");
            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Listar Chamados");
            Console.WriteLine("3 - Atualizar Status");
            Console.WriteLine("4 - Estatísticas");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    cadastrarChamado(chamados);
                    break;

                case 2:
                    listarChamados(chamados);
                    break;

                case 3:
                    atualizarStatus(chamados);
                    break;

                case 4:
                    estatisticas(chamados);
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }
}