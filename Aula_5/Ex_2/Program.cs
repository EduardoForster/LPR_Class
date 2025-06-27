using System;

class Program
{
    static void Main(string[] args)
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101); 
        int tentativas = 0;
        int chute = 0;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

        while (chute != valorInteiro)
        {
            Console.Write("Digite seu chute: ");
            chute = int.Parse(Console.ReadLine());
            tentativas++;

            if (chute < valorInteiro)
            {
                Console.WriteLine("Chutou baixo!");
            }
            else if (chute > valorInteiro)
            {
                Console.WriteLine("Chutou alto!");
            }
            else
            {
                Console.WriteLine($"Acertou! O número era {valorInteiro}.");
                Console.WriteLine($"Você precisou de {tentativas} tentativa(s) para acertar.");
            }
        }
    }
}