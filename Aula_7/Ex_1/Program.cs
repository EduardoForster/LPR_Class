using System;
class ParEImpar
{    static void Main()
    {
        int[] numeros = new int[10];
        int[] pares = new int[10]; 
        int[] impares = new int[10]; 
        int contPares = 0;
        int contImpares = 0;

        Console.WriteLine("Digite 10 números:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro:");
                Console.Write($"Número {i + 1}: ");
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares[contPares] = numeros[i];
                contPares++;
            }
            else
            {
                impares[contImpares] = numeros[i];
                contImpares++;
            }
        }
        Console.WriteLine("\nNúmeros pares digitados:");
        if (contPares == 0)
        {
            Console.WriteLine("Nenhum número par digitado.");
        }
        else
        {
            for (int i = 0; i < contPares; i++)
            {
                Console.Write(pares[i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nNúmeros ímpares digitados:");
        if (contImpares == 0)
        {
            Console.WriteLine("Nenhum número ímpar digitado.");
        }
        else
        {
            for (int i = 0; i < contImpares; i++)
            {
                Console.Write(impares[i] + " ");
            }
            Console.WriteLine();
        }
    }
}



