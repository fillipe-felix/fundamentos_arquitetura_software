namespace SOLID._5___DIP.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(_1___SRP.SRP.Solucao.Cliente cliente)
        {
            if (!cliente.Validar())
            {
                return "Dados inválidos";
            }

            var repo = new _1___SRP.SRP.Solucao.ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@teste.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso";
        }
    }
}