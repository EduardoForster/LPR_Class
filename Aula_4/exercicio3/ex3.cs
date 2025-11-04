using System;

namespace RPGGame
{
    // Classe base para personagens
    abstract class Personagem
    {
        public string Nome { get; protected set; }

        protected Personagem(string nome)
        {
            Nome = nome;
        }

        public abstract void ExibirHabilidades();
    }

    // Classe Guerreiro
    class Guerreiro : Personagem
    {
        public Guerreiro() : base("Guerreiro") { }
        public override void ExibirHabilidades()
        {
            Console.WriteLine("- Golpe Poderoso");
            Console.WriteLine("- Defesa de Ferro");
        }
    }

    // Classe Mago
    class Mago : Personagem
    {
        public Mago() : base("Mago") { }
        public override void ExibirHabilidades()
        {
            Console.WriteLine("- Bola de Fogo");
            Console.WriteLine("- Escudo Arcano");
        }
    }

    // Classe Arqueiro
    class Arqueiro : Personagem
    {
        public Arqueiro() : base("Arqueiro") { }
        public override void ExibirHabilidades()
        {
            Console.WriteLine("- Tiro Preciso");
            Console.WriteLine("- Flecha Explosiva");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha sua classe:");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueiro");

            Console.Write("Digite o número da classe: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int escolha))
            {
                // Agora a variável jogador é anulável (Personagem?)
                Personagem? jogador = escolha switch
                {
                    1 => new Guerreiro(),
                    2 => new Mago(),
                    3 => new Arqueiro(),
                    _ => null // Agora podemos atribuir null de forma segura
                };

                if (jogador != null)
                {
                    Console.WriteLine($"\nVocê escolheu a classe: {jogador.Nome}\n");
                    jogador.ExibirHabilidades();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um número.");
            }
        }
    }
}
