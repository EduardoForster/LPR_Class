using System;

class Program
{

    static string[] nomes = new string[5];
    static string[] poderes = new string[5];
    static int[] pontuacoes = new int[5];
    static int contadorHerois = 0;

    static void Main()
    {
    while (true) {
    Console.WriteLine("\n1. Cadastrar Herói\n2. Selecionar Equipe\n3. Exibir Equipe\n4. Sair");
    
    switch (Console.ReadLine()) {

    case "1": CadastrarHeroi(); break;
    case "2": SelecionarEquipe(); break;
    case "3": ExibirEquipe(); break;
    case "4": return;
    default: Console.WriteLine("Opção inválida."); break;
    }
    }
    }

    static void CadastrarHeroi()
    {
    if (contadorHerois >= 5) {

    Console.WriteLine("Limite de heróis atingido.");
    return;
    }
    Console.Write("Nome: "); nomes[contadorHerois] = Console.ReadLine();
    Console.Write("Poder: "); poderes[contadorHerois] = Console.ReadLine();
    Console.Write("Pontuação: "); pontuacoes[contadorHerois++] = int.Parse(Console.ReadLine());
    Console.WriteLine("Herói cadastrado!");
    }

    static void SelecionarEquipe()
    {
    if (contadorHerois == 0) { Console.WriteLine("Cadastre heróis primeiro."); return; }

    string[] equipe = new string[3];
    int[] pontuacoesEquipe = new int[3];

    for (int i = 0; i < 3; i++) {

    Console.WriteLine("Heróis cadastrados:");
    
    for (int j = 0; j < contadorHerois; j++)
                
    Console.WriteLine($"{j + 1}. {nomes[j]} - {poderes[j]} - {pontuacoes[j]}");

    Console.Write($"Selecione o herói {i + 1}: ");
            
    int escolha = int.Parse(Console.ReadLine()) - 1;
    
    if (escolha >= 0 && escolha < contadorHerois) {
    equipe[i] = nomes[escolha];
    pontuacoesEquipe[i] = pontuacoes[escolha];
    }
            
    else { Console.WriteLine("Escolha inválida."); i--; }
    }
    ExibirEquipe(equipe, pontuacoesEquipe);
    }

    static void ExibirEquipe(string[] equipe, int[] pontuacoesEquipe) {

    int total = 0;
    Console.WriteLine("\nEquipe selecionada:");
    
    for (int i = 0; i < equipe.Length; i++) {
    Console.WriteLine($"{i + 1}. {equipe[i]} - Pontuação: {pontuacoesEquipe[i]}");
    total += pontuacoesEquipe[i];
    }
    Console.WriteLine($"Pontuação total: {total}");
=======
    static void Main(string[] args)
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        string[] nomes = new string[5];
        string[] poderes = new string[5];
        int[] pontuacoes = new int[5];
        int contadorHerois = 0;
        int[] equipe = new int[3];
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1. Cadastrar Heróis");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    if (contadorHerois < 5)
                    {
                        cadastrarHeroi(nomes, poderes, pontuacoes, contadorHerois);
                        contadorHerois++;
                    }
                    else
                    {
                        Console.WriteLine("Limite de heróis cadastrados atingido.");
                    }
                    break;
                case "2":
                    if (contadorHerois > 0)
                    {
                        selecionarEquipe(nomes, contadorHerois, equipe);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum herói cadastrado.");
                    }
                    break;
                case "3":
                    exibirEquipe(nomes, poderes, pontuacoes, equipe);
                    break;
                case "0":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void cadastrarHeroi(string[] nomes, string[] poderes, int[] pontuacoes, int index)
    {
        Console.Write("Digite o nome do herói: ");
        nomes[index] = Console.ReadLine();
        Console.Write("Digite o poder do herói: ");
        poderes[index] = Console.ReadLine();
        Console.Write("Digite a pontuação do herói: ");
        pontuacoes[index] = int.Parse(Console.ReadLine());
        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void selecionarEquipe(string[] nomes, int contadorHerois, int[] equipe)
    {
        Console.WriteLine("Heróis cadastrados:");
        for (int i = 0; i < contadorHerois; i++)
        {
            Console.WriteLine($"{i + 1}. {nomes[i]}");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Selecione o herói {i + 1} para a equipe (1 a {contadorHerois}): ");
            equipe[i] = int.Parse(Console.ReadLine()) - 1;
        }
    }

    static void exibirEquipe(string[] nomes, string[] poderes, int[] pontuacoes, int[] equipe)
    {
        Console.WriteLine("Equipe selecionada:");
        int pontuacaoTotal = 0;

        for (int i = 0; i < 3; i++)
        {
            int index = equipe[i];
            Console.WriteLine($"Herói: {nomes[index]}, Poder: {poderes[index]}, Pontuação: {pontuacoes[index]}");
            pontuacaoTotal += pontuacoes[index];
        }

        Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotal}");

    }
}