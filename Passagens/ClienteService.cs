namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public Cliente Buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(nome);
        }
        public void Add(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Add(c);
        }
    }
}