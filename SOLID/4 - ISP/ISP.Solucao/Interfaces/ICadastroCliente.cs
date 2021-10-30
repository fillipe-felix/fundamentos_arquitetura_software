namespace SOLID._4___ISP.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}