using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando clientes
        Cliente cliente1 = new Cliente("João Silva", "joao@email.com", "11999999999");
        Cliente cliente2 = new Cliente("Maria Santos", "maria@email.com", "11888888888");
        
        // Criando reservas
        Reserva reserva1 = new Reserva(1, DateTime.Now.AddDays(5), "Mesa 5", cliente1);
        Reserva reserva2 = new Reserva(2, DateTime.Now.AddDays(10), "Sala VIP", cliente1);
        Reserva reserva3 = new Reserva(3, DateTime.Now.AddDays(-2), "Mesa 3", cliente1); // Reserva passada
        Reserva reserva4 = new Reserva(4, DateTime.Now.AddDays(7), "Mesa 10", cliente2);
        
        // Adicionando reservas aos clientes
        cliente1.AdicionarReserva(reserva1);
        cliente1.AdicionarReserva(reserva2);
        cliente1.AdicionarReserva(reserva3);
        cliente2.AdicionarReserva(reserva4);
        
        // Demonstração
        Console.WriteLine("=== SISTEMA DE RESERVAS ===");
        
        Console.WriteLine("\n--- CLIENTE 1 ---");
        cliente1.MostrarDados();
        
        Console.WriteLine("\n--- CLIENTE 2 ---");
        cliente2.MostrarDados();
        
        Console.WriteLine("\n=== RESERVAS FUTURAS ===");
        Console.WriteLine("\nReservas futuras do João:");
        cliente1.ListarReservasFuturas();
        
        Console.WriteLine("\nReservas futuras da Maria:");
        cliente2.ListarReservasFuturas();
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
        Console.WriteLine($"Reserva {reserva.Id} adicionada para {Nome}");
    }

    public void ListarReservasFuturas()
    {
        var reservasFuturas = Reservas.Where(r => r.DataReserva > DateTime.Now).ToList();
        
        if (reservasFuturas.Count == 0)
        {
            Console.WriteLine($"{Nome} não possui reservas futuras.");
            return;
        }

        Console.WriteLine($"Reservas futuras de {Nome}:");
        foreach (var reserva in reservasFuturas)
        {
            Console.WriteLine($"- ID: {reserva.Id} | Data: {reserva.DataReserva:dd/MM/yyyy} | Local: {reserva.Local}");
        }
    }

    public void CancelarReserva(int idReserva)
    {
        var reserva = Reservas.Find(r => r.Id == idReserva);
        if (reserva != null)
        {
            Reservas.Remove(reserva);
            Console.WriteLine($"Reserva {idReserva} cancelada com sucesso!");
        }
        else
        {
            Console.WriteLine($"Reserva {idReserva} não encontrada.");
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
    public int Id { get; set; }
    public DateTime DataReserva { get; set; }
    public string Local { get; set; }
    public Cliente Cliente { get; set; }
    public string Status { get; set; }

    public Reserva(int id, DateTime dataReserva, string local, Cliente cliente)
    {
        Id = id;
        DataReserva = dataReserva;
        Local = local;
        Cliente = cliente;
        Status = "Ativa";
    }

    public void ConfirmarReserva()
    {
        Status = "Confirmada";
        Console.WriteLine($"Reserva {Id} confirmada para {Cliente.Nome}");
    }

    public void CancelarReserva()
    {
        Status = "Cancelada";
        Console.WriteLine($"Reserva {Id} cancelada");
    }

    public bool EhReservaFutura()
    {
        return DataReserva > DateTime.Now;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Reserva ID: {Id}");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"Data: {DataReserva:dd/MM/yyyy HH:mm}");
        Console.WriteLine($"Local: {Local}");
        Console.WriteLine($"Status: {Status}");
    }

    public void AlterarData(DateTime novaData)
    {
        DataReserva = novaData;
        Console.WriteLine($"Data da reserva {Id} alterada para {novaData:dd/MM/yyyy}");
    }
}


