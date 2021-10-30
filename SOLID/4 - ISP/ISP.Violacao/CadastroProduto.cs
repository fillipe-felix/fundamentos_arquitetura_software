using System;

namespace SOLID._4___ISP.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela cliente
        }

        public void EnviarEmail()
        {
            // Produto não tem e-mail, o que faço agora???
            throw new NotImplementedException("Esse método não serve para nada");
        }
    }
}