using System;

namespace PersistenciaDatos_TP_DDD_RepositorioEnMemoria
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Trabajo Practico de Laboratorio de Software");
            Console.WriteLine("Proyecto Hotel Arquitectura DDD");
            Console.WriteLine();
            Console.WriteLine("Profesor: Daniel Alejandro Fernandez");
            Console.WriteLine("Alumnos: Julia Avalos");
            Console.WriteLine("         Leonardo Caceres");
            Console.WriteLine("         Eduardo Arizza");
            Console.WriteLine("         Gonzalo Arizza");
            Console.WriteLine("         Omar Bazar");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            // Crear un repositorio de clientes en memoria
            var repositorio = new ClienteRepositorioEnMemoria();

            // Crear algunos clientes
            var cliente1 = new Cliente(Guid.NewGuid(), "John Doe", "john.doe@example.com", "password123", new DateTime(1990, 1, 1));
            var cliente2 = new Cliente(Guid.NewGuid(), "Jane Doe", "jane.doe@example.com", "password456", new DateTime(1995, 5, 5));

            // Grabar los clientes en el repositorio
            repositorio.grabar(cliente1);
            repositorio.grabar(cliente2);

            // Listar todos los clientes
            var clientes = repositorio.listar();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id()}, Nombre: {cliente.Nombre()}, Email: {cliente.Email()}");
            }

            // Eliminar un cliente
            repositorio.eliminar(cliente1.Id());

            // Listar todos los clientes nuevamente
            clientes = repositorio.listar();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id()}, Nombre: {cliente.Nombre()}, Email: {cliente.Email()}");
            }
        }
    }
}