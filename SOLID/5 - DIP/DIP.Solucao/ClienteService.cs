using SOLID._5___DIP.DIP.Solucao.Interfaces;

namespace SOLID._5___DIP.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailService;

        public ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailService = emailService;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
            {
                return "Dados inválidos";
            }
            
            _clienteRepository.AdicionarCliente(cliente);

            _emailService.Enviar("empresa@teste.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso";
        }
    }

    public class TesteDip
    {
        public TesteDip()
        {
            var clienteService = new ClienteService(new ClienteRepository2(), new EmailService());
        }
    }
}