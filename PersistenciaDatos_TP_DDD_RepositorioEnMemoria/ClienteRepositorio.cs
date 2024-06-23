using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaDatos_TP_DDD_RepositorioEnMemoria
{
    public interface ClienteRepositorio
    {
        List<Cliente> listar();
        void grabar(Cliente cliente);
        void eliminar(Guid id);
    }
}
