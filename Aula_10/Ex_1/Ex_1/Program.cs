using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.Write("Digite a largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"Área: {retangulo.CalcArea():F2}");
        Console.WriteLine($"Perímetro: {retangulo.CalcPerimetro():F2}");
    }
}

public class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double CalcArea()
    {
        return Largura * Altura;
    }

    public double CalcPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}