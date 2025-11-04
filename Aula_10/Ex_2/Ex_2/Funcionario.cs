using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.Write("Digite o nome do funcionário: ");
        funcionario.Nome = Console.ReadLine();

        Console.Write("Digite o salário bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine());

        funcionario.MostrarDados();

        Console.Write("\nDigite a porcentagem de aumento: ");
        double porcentagem = double.Parse(Console.ReadLine());
        funcionario.AumentarSalario(porcentagem);

        Console.WriteLine("\nDados atualizados:");
        funcionario.MostrarDados();
    }
}

public class Funcionario
{
    public string Nome { get; set; }
    public double SalarioBruto { get; set; }

    public double CalcularImposto()
    {
        if (SalarioBruto <= 2000)
            return SalarioBruto * 0.10;
        else if (SalarioBruto <= 3000)
            return SalarioBruto * 0.15;
        else
            return SalarioBruto * 0.20;
    }

    public double SalarioLiquido()
    {
        return SalarioBruto - CalcularImposto();
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário Líquido: R$ {SalarioLiquido():F2}");
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * (porcentagem / 100);
    }
}