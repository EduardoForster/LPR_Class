using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite quantos números serão informados:");
        int quantidade = int.Parse(Console.ReadLine());

        int somaPares = 0;
        int contadorPares = 0;
        int i = 0;

        while (i < quantidade)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                somaPares += numero;
                contadorPares++;
            }
            i++;
        }
        if (contadorPares > 0)
        {
            double media = (double)somaPares / contadorPares;
            Console.WriteLine($"A média aritmética dos números pares é: {media}");
        }
        else
        {
            Console.WriteLine("Nenhum número par informado.");
        }
    }
}