namespace PersistenciaDatos_TP_DDD_RepositorioEnMemoria
{
    public class ClienteRepositorioEnMemoria : ClienteRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>();



        public List<Cliente> listar()
        {
            return clientes;
            //          throw new NotImplementedException();
        }

        public void grabar(Cliente cliente)
        {

            clientes.Add(cliente);
            //       throw new NotImplementedException();
        }

        public void eliminar(Guid id)
        {
            clientes.RemoveAll(c => c.Id() == id);
            //       throw new NotImplementedException();
        }
    }
}