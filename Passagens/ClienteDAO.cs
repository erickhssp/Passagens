using System.Collections.Generic;
using System.Linq;

namespace Passagens
{
    class ClienteDAO
    {
        private static IList<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome));
            return (Cliente)resultado;
        }
    }
}