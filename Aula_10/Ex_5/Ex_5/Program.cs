using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando cliente
        Cliente cliente1 = new Cliente("Eduardo Forster", "eduardo@email.com", "dudu123");
        
        // Criando reservas
        Reserva reserva1 = new Reserva(DateTime.Now.AddDays(5), "Casa do Gromp", cliente1);
        Reserva reserva2 = new Reserva(DateTime.Now.AddDays(-2), "Pitch do Drag", cliente1);
        Reserva reserva3 = new Reserva(DateTime.Now.AddDays(10), "Pitch do Baron", cliente1);
        
        // Adicionando reservas ao cliente
        cliente1.AdicionarReserva(reserva1);
        cliente1.AdicionarReserva(reserva2);
        cliente1.AdicionarReserva(reserva3);
        
        // Demonstração
        Console.WriteLine("=== SISTEMA DE RESERVAS ===");
        cliente1.MostrarDados();
        
        Console.WriteLine("\n=== TODAS AS RESERVAS ===");
        cliente1.ListarTodasReservas();
        
        Console.WriteLine("\n=== RESERVAS FUTURAS ===");
        cliente1.ListarReservasFuturas();
    }
}

public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public List<Reserva> Reservas { get; set; }

    public Cliente(string nome, string email, string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Reservas = new List<Reserva>();
    }

    public void AdicionarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
        Console.WriteLine($"Reserva adicionada para {Nome}: {reserva.Local}");
    }

    public void ListarReservasFuturas()
    {
        var reservasFuturas = Reservas.Where(r => r.DataReserva > DateTime.Now).ToList();
        
        if (reservasFuturas.Count > 0)
        {
            Console.WriteLine($"Reservas futuras de {Nome}:");
            foreach (var reserva in reservasFuturas)
            {
                reserva.MostrarDetalhes();
            }
        }
        else
        {
            Console.WriteLine($"{Nome} não possui reservas futuras.");
        }
    }

    public void ListarTodasReservas()
    {
        Console.WriteLine($"Todas as reservas de {Nome}:");
        foreach (var reserva in Reservas)
        {
            reserva.MostrarDetalhes();
        }
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Total de Reservas: {Reservas.Count}");
    }
}

public class Reserva
{
    public DateTime DataReserva { get; set; }
    public string Local { get; set; }
    public Cliente Cliente { get; set; }
    public int NumeroReserva { get; set; }
    public static int ContadorReserva = 1000;

    public Reserva(DateTime dataReserva, string local, Cliente cliente)
    {
        DataReserva = dataReserva;
        Local = local;
        Cliente = cliente;
        NumeroReserva = ++ContadorReserva;
    }

    public void MostrarDetalhes()
    {
        string status = DataReserva > DateTime.Now ? "FUTURA" : "PASSADA";
        Console.WriteLine($"  Reserva #{NumeroReserva} - {Local}");
        Console.WriteLine($"  Data: {DataReserva:dd/MM/yyyy HH:mm} ({status})");
        Console.WriteLine($"  Cliente: {Cliente.Nome}");
        Console.WriteLine();
    }

    public void CancelarReserva()
    {
        Console.WriteLine($"Reserva #{NumeroReserva} cancelada para {Cliente.Nome}");
    }
}