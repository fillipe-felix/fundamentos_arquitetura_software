using System.Data;
using System.Data.SqlClient;
using SOLID._5___DIP.DIP.Solucao.Interfaces;

namespace SOLID._5___DIP.DIP.Solucao
{
    public class ClienteRepository2 : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            // outra forma de salvar o cliente no banco de dados
        }
    }
} 