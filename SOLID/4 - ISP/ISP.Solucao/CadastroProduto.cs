using System;
using SOLID._4___ISP.ISP.Solucao.Interfaces;


namespace SOLID._4___ISP.ISP.Solucao
{
    public class CadastroProduto : ICadastroProduto
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela cliente
        }
    }
}