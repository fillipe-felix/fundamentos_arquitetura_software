namespace SOLID._1___SRP.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
            {
                return "Dados inválidos";
            }

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@teste.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso";
        }
    }
}