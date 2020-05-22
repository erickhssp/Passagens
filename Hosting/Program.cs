using Passagens;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClienteService));
            
            //Criando o endereço
            Uri endereco = new Uri("http://localhost:8080/clientes");

            //Criando o EndPoint
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);

            try
            {
                host.Open();
                ExibeInformacoesServico(host); // exibindo as informações do serviço. // Verificar se o vs está sendo utilizado como ADM
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        //Método que exibe no console todos os EndPoints do serviço.
        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}