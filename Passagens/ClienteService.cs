using System.Collections.Generic;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public Cliente Buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(nome);
        }
        public bool Add(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.CPF = cpf;

            ClienteDAO dao = new ClienteDAO();
            dao.Add(c);

            return true;
        }
        public List<Cliente> getClientes()
        {
            return ClienteDAO.clientes;
        }
    }
}