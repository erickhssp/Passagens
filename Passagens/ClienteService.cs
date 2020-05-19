namespace Passagens
{
    class ClienteService : IclienteService
    {
        private readonly ClienteDAO dao;

        public ClienteService(ClienteDAO clienteDAO)
        {
            this.dao = clienteDAO;
        }
        public void Add(Cliente c)
        {
            dao.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            return dao.Buscar(nome);
        }
    }
}