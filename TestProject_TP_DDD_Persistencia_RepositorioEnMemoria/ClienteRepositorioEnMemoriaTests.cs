using PersistenciaDatos_TP_DDD_RepositorioEnMemoria;
using System;
using Xunit;

namespace TestProject_TP_DDD_Persistencia_RepositorioEnMemoria
{
    public class ClienteRepositorioEnMemoriaTests
    {
           
        [Fact]
        public void Deberia_Listar_Todos_Los_Clientes()
        {
            // Arrange
            var repositorio = new ClienteRepositorioEnMemoria();
            var cliente1 = new Cliente(Guid.NewGuid(), "John Doe", "john.doe@example.com", "password123", new DateTime(1990, 1, 1));
            var cliente2 = new Cliente(Guid.NewGuid(), "Jane Doe", "jane.doe@example.com", "password456", new DateTime(1995, 5, 5));
            repositorio.grabar(cliente1);
            repositorio.grabar(cliente2);

            // Act
            var clientes = repositorio.listar();

            // Assert
            Assert.Equal(2, clientes.Count);
            Assert.Contains(cliente1, clientes);
            Assert.Contains(cliente2, clientes);
        }

        [Fact]
        public void Deberia_Grabar_Un_Cliente()
        {
            // Arrange
            var repositorio = new ClienteRepositorioEnMemoria();
            var cliente = new Cliente(Guid.NewGuid(), "John Doe", "john.doe@example.com", "password123", new DateTime(1990, 1, 1));

            // Act
            repositorio.grabar(cliente);
            var clientes = repositorio.listar();

            // Assert
            Assert.Single(clientes);
            Assert.Contains(cliente, clientes);
        }

        [Fact]
        public void Deberia_Eliminar_Un_Cliente()
        {
            // Arrange
            var repositorio = new ClienteRepositorioEnMemoria();
            var cliente1 = new Cliente(Guid.NewGuid(), "John Doe", "john.doe@example.com", "password123", new DateTime(1990, 1, 1));
            var cliente2 = new Cliente(Guid.NewGuid(), "Jane Doe", "jane.doe@example.com", "password456", new DateTime(1995, 5, 5));
            repositorio.grabar(cliente1);
            repositorio.grabar(cliente2);

            // Act
            repositorio.eliminar(cliente1.Id());
            var clientes = repositorio.listar();

            // Assert
            Assert.Single(clientes);
            Assert.DoesNotContain(cliente1, clientes);
            Assert.Contains(cliente2, clientes);
        }
    }
}