using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando biblioteca
        Biblioteca biblioteca = new Biblioteca("Biblioteca Central");
        
        // Criando livros
        Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro2 = new Livro("O Cortiço", "Aluísio Azevedo", 1890);
        Livro livro3 = new Livro("Iracema", "José de Alencar", 1865);
        
        // Testando o sistema
        Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
        Console.WriteLine($"Biblioteca: {biblioteca.GetNome()}");
        
        // Adicionando livros
        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);
        
        Console.WriteLine($"\nTotal de livros: {biblioteca.GetTotalLivros()}");
        
        // Listando todos os livros
        Console.WriteLine("\n=== ACERVO DA BIBLIOTECA ===");
        biblioteca.ListarLivros();
        
        // Testando getters e setters
        Console.WriteLine("\n=== TESTANDO GETTERS/SETTERS ===");
        Console.WriteLine($"Primeiro livro: {livro1.GetTitulo()} - {livro1.GetAutor()} ({livro1.GetAnoPublicacao()})");
        
        // Modificando um livro
        livro1.SetTitulo("Dom Casmurro - Edição Especial");
        Console.WriteLine($"Título modificado: {livro1.GetTitulo()}");
    }
}

public class Livro
{
    private string titulo;
    private string autor;
    private int anoPublicacao;

    // Construtor
    public Livro(string titulo, string autor, int anoPublicacao)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anoPublicacao = anoPublicacao;
    }

    // Getters
    public string GetTitulo()
    {
        return titulo;
    }

    public string GetAutor()
    {
        return autor;
    }

    public int GetAnoPublicacao()
    {
        return anoPublicacao;
    }

    // Setters
    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetAutor(string autor)
    {
        this.autor = autor;
    }

    public void SetAnoPublicacao(int anoPublicacao)
    {
        this.anoPublicacao = anoPublicacao;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"  Título: {titulo}");
        Console.WriteLine($"  Autor: {autor}");
        Console.WriteLine($"  Ano: {anoPublicacao}");
        Console.WriteLine();
    }
}

public class Biblioteca
{
    private string nome;
    private List<Livro> livros;

    // Construtor
    public Biblioteca(string nome)
    {
        this.nome = nome;
        this.livros = new List<Livro>();
    }

    // Getters
    public string GetNome()
    {
        return nome;
    }

    public List<Livro> GetLivros()
    {
        return livros;
    }

    public int GetTotalLivros()
    {
        return livros.Count;
    }

    // Setters
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    // Método AdicionarLivro
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro '{livro.GetTitulo()}' adicionado à biblioteca!");
    }

    // Método ListarLivros
    public void ListarLivros()
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("A biblioteca não possui livros.");
            return;
        }

        Console.WriteLine($"Livros disponíveis na {nome}:");
        for (int i = 0; i < livros.Count; i++)
        {
            Console.WriteLine($"\n[{i + 1}]");
            livros[i].MostrarDetalhes();
        }
    }

    public Livro BuscarLivroPorTitulo(string titulo)
    {
        foreach (Livro livro in livros)
        {
            if (livro.GetTitulo().ToLower().Contains(titulo.ToLower()))
            {
                return livro;
            }
        }
        return null;
    }
}
