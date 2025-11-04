using System;
class Program
{    static void Main()
    {
        Console.Write("Digite um número inteiro: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
        else
        {
            Console.WriteLine("Insira um número inteiro válido.");
        }
    }
}