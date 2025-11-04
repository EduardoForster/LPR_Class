using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Digite a matrícula: ");
        aluno.Matricula = Console.ReadLine();

        Console.Write("Digite o nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite a primeira nota da prova: ");
        aluno.NotaProva1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota da prova: ");
        aluno.NotaProva2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota do trabalho: ");
        aluno.NotaTrabalho = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nAluno: {aluno.Nome}");
        Console.WriteLine($"Matrícula: {aluno.Matricula}");
        Console.WriteLine($"Média final: {aluno.Media():F2}");
        
        double notaFinal = aluno.Final();
        if (notaFinal > 0)
            Console.WriteLine($"Precisa tirar {notaFinal:F2} na prova final");
        else
            Console.WriteLine("Aprovado! Não precisa fazer prova final");
    }
}

public class Aluno
{
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public double NotaProva1 { get; set; }
    public double NotaProva2 { get; set; }
    public double NotaTrabalho { get; set; }

    public double Media()
    {
        return (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7;
    }

    public double Final()
    {
        double mediaAtual = Media();
        if (mediaAtual >= 7.0)
            return 0;
        else
            return (12.5 - mediaAtual * 1.6) / 0.4;
    }
}
