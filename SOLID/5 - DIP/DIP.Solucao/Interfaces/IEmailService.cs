namespace SOLID._5___DIP.DIP.Solucao.Interfaces
{
    public interface IEmailService
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}