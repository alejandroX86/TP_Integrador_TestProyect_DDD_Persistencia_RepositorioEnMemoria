using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaDatos_TP_DDD_RepositorioEnMemoria
{
    public class Cliente
    {
        private Guid id;
        private string nombre;
        private string email;
        private string password;
        private DateTime fechaNacimiento;

        public Cliente(Guid id, string nombre, string email, string password, DateTime fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Guid Id()
        {
            return id;
        }

        public string Nombre()
        {
            return nombre;
        }

        public string Email()
        {
            return email;
        }

        public string Password()
        {
            return password;
        }

        public DateTime FechaNacimiento()
        {
            return fechaNacimiento;
        }
    }
}
